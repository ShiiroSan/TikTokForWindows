using LibVLCSharp.Shared;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Image = System.Windows.Controls.Image;
using MediaPlayer = LibVLCSharp.Shared.MediaPlayer;

namespace TikTokForWindows
{
    public partial class MainWindow : Window
    {
        private LibVLC _libVLC;
        private MediaPlayer _mp;

        Image PlayImageElem;
        Image LikeImage;
        Image NotlikeImage;
        BitmapImage PlayBitmapImage;
        BitmapImage LikeBitmapImage;
        BitmapImage NotlikeBitmapImage;

        private void volumeThreadFunc()
        {
            byte alphaVal = 0;
            while (true)
            {
                if (volumeTimer > DateTime.Now)
                {/*
                    if (alphaVal < 255)
                    {
                        alphaVal += 100;
                        if (alphaVal > 255) alphaVal = 255;
                    }
                    */
                    alphaVal = 255;
                }
                else
                {
                    /*
                    if (alphaVal != 0)
                    {
                        alphaVal -= 100;
                        if (alphaVal < 0) alphaVal = 0;
                    }
                    */
                    alphaVal = 0;
                }
                try
                {
                    ThreadPool.QueueUserWorkItem(_ => volumeLabel.Dispatcher.Invoke(() => volumeLabel.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(alphaVal, 255, 255, 255))));
                }
                catch (Exception)
                {
                }

                Thread.Sleep(300);
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            volumeTimer = DateTime.Now;
            volumeThread = new Thread(volumeThreadFunc);
            volumeThread.Start();
            //TikTokLogin.XorEncrypt("password");
            /* Following part is made to get libVLC DLLs, as they are not copied in main folder*/
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            string VlcLibDirectory = new DirectoryInfo(System.IO.Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64")).FullName;
            Core.Initialize(VlcLibDirectory);

            listOfTikTokObj = getNewTikTokObjList();
            var newVid = new TikTokSimplifiedObject(getNextTikTokObj());

            videoURL = newVid.VideoUrl;
            authorImage.Source = newVid.AuthorImage;
            authorNameLabel.Text = newVid.AuthorName;
            videoDescriptionLabel.Document = newVid.VideoDesc;
            likeNbrLabel.Content = Utils.NormalizeNumber(newVid.LikeNbr);
            commentNbrLabel.Content = Utils.NormalizeNumber(newVid.CommentNbr);
            shareNbrLabel.Content = Utils.NormalizeNumber(newVid.ShareNbr);
            rawLinkText.Text = newVid.VideoUrl;

            _libVLC = new LibVLC("");
            _mp = new MediaPlayer(_libVLC);
            _mp.EnableMouseInput = true;
            videoView.MediaPlayer = _mp;

            _mp.Volume = 10;
            volumeSlider.Value = _mp.Volume;

            var mediaVid = new Media(_libVLC, videoURL, FromType.FromLocation);
            _mp.Play(mediaVid);

            _mp.TimeChanged += TimeChanged;
            _mp.EndReached += EndReached;
            _mp.VolumeChanged += VolumeChanged;

            PlayImageElem = new Image();
            var UriStringPlay = @"pack://application:,,,/TikTokForWindows;component/Resources/play-button.png";
            var UriBitmapImageSourcePlay = new Uri(UriStringPlay, UriKind.Absolute);
            PlayBitmapImage = new BitmapImage(UriBitmapImageSourcePlay);
            PlayImageElem.Source = PlayBitmapImage;

            LikeImage = new Image();
            var UriStringLike = @"pack://application:,,,/TikTokForWindows;component/Resources/like-button.png";
            var UriBitmapImageSourceLike = new Uri(UriStringLike, UriKind.Absolute);
            LikeBitmapImage = new BitmapImage(UriBitmapImageSourceLike);
            LikeImage.Source = LikeBitmapImage;

            NotlikeImage = new Image();
            var UriStringNotLike = @"pack://application:,,,/TikTokForWindows;component/Resources/notlike-button.png";
            var UriBitmapImageSourceNotLike = new Uri(UriStringNotLike, UriKind.Absolute);
            NotlikeBitmapImage = new BitmapImage(UriBitmapImageSourceNotLike);
            NotlikeImage.Source = NotlikeBitmapImage;
        }

        /** VIDEO MANAGEMENT **/

        private string videoURL;
        private List<AwemeStructV2> listOfTikTokObj;
        private int positionOfTikTokObjList = -1;

        private List<AwemeStructV2> getNewTikTokObjList()
        {
            List<AwemeStructV2> listOfTikTokObj = new List<AwemeStructV2>();
            aweme_v2_feed_response m_jsonTikTokFeed = TikTokManager.GetFeed();
            for (int i = 0; i < m_jsonTikTokFeed.aweme_list.Count; i++)
            {
                listOfTikTokObj.Add(m_jsonTikTokFeed.aweme_list[i]);
            }
            return listOfTikTokObj;
        }

        private AwemeStructV2 getPrevTikTokObj()
        {
            positionOfTikTokObjList--;
            if (positionOfTikTokObjList < 0)
            {
                listOfTikTokObj.Clear();
                listOfTikTokObj.AddRange(getNewTikTokObjList()); //This is to reproduce when you do random search on foryou page
                positionOfTikTokObjList = 0;
            }
            return listOfTikTokObj[positionOfTikTokObjList];
        }

        private AwemeStructV2 getNextTikTokObj()
        {
            positionOfTikTokObjList++;
            if (positionOfTikTokObjList == listOfTikTokObj.Count)
            {
                listOfTikTokObj.AddRange(getNewTikTokObjList());
            }
            return listOfTikTokObj[positionOfTikTokObjList];
        }



        /** VOLUME MANAGEMENT **/

        DateTime volumeTimer = new DateTime();
        Thread volumeThread;

        private void volumeManagement(MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (_mp.Volume > 100)
                {
                    _mp.Volume = 100;
                }
                else
                {
                    _mp.Volume += 5;
                }
            }

            else if (e.Delta < 0)
            {
                if (_mp.Volume < 0)
                {
                    _mp.Volume = 0;
                }
                else
                {
                    _mp.Volume -= 5;
                }
            }

        }

        /** GUI MANAGEMENT **/

        private bool isPlaying = true;

        private void playPause_Click(object sender, RoutedEventArgs e)
        {
            if (isPlaying)
            {
                isPlaying = !isPlaying;
                _mp.Pause();
                //playPauseBtn.Content = PlayImage;
            }
            else
            {

                isPlaying = !isPlaying;
                _mp.Play();
                //playPauseBtn.Content = PauseImage;
            }
        }

        private void nextVideo_Click(object sender, RoutedEventArgs e)
        {
            var newVid = new TikTokSimplifiedObject(getNextTikTokObj());

            videoURL = newVid.VideoUrl;
            authorImage.Source = newVid.AuthorImage;
            authorNameLabel.Text = newVid.AuthorName;
            videoDescriptionLabel.Document = newVid.VideoDesc;
            likeNbrLabel.Content = Utils.NormalizeNumber(newVid.LikeNbr);
            commentNbrLabel.Content = Utils.NormalizeNumber(newVid.CommentNbr);
            shareNbrLabel.Content = Utils.NormalizeNumber(newVid.ShareNbr);
            rawLinkText.Text = newVid.VideoUrl;
            _mp.Play(new Media(_libVLC, videoURL, FromType.FromLocation));
        }

        private void prevVid_Click(object sender, RoutedEventArgs e)
        {
            var prevVid = new TikTokSimplifiedObject(getPrevTikTokObj());

            videoURL = prevVid.VideoUrl;
            authorImage.Source = prevVid.AuthorImage;
            authorNameLabel.Text = prevVid.AuthorName;
            videoDescriptionLabel.Document = prevVid.VideoDesc;
            likeNbrLabel.Content = Utils.NormalizeNumber(prevVid.LikeNbr);
            commentNbrLabel.Content = Utils.NormalizeNumber(prevVid.CommentNbr);
            shareNbrLabel.Content = Utils.NormalizeNumber(prevVid.ShareNbr);
            rawLinkText.Text = prevVid.VideoUrl;
            _mp.Play(new Media(_libVLC, videoURL, FromType.FromLocation));
        }

        /** EVENT MANAGEMENT **/

        private void TimeChanged(object sender, System.EventArgs e)
        {
            if (_mp.Length == 0)
            {
                Thread.Sleep(100);
            }
            double videoProgressValue = _mp.Time * 100 / _mp.Length;
            ThreadPool.QueueUserWorkItem(_ => videoProgress.Dispatcher.Invoke(() => videoProgress.Value = videoProgressValue)); //Dispatcher.Invoke is used to modify element form within another thread
        }

        private void EndReached(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(_ => _mp.Play(new Media(_libVLC, videoURL, FromType.FromLocation)));
            ThreadPool.QueueUserWorkItem(_ => videoProgress.Dispatcher.Invoke(() => videoProgress.Value = 0));
        }

        private void VolumeChanged(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(_ => volumeSlider.Dispatcher.Invoke(() => volumeSlider.Value = _mp.Volume));
            ThreadPool.QueueUserWorkItem(_ => volumeLabel.Dispatcher.Invoke(() => volumeLabel.Content = _mp.Volume));

            volumeTimer = DateTime.Now.AddSeconds(4);
        }
        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _mp.Volume = (int)volumeSlider.Value;
        }

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            volumeManagement(e);
        }

        private void videoView_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            volumeManagement(e);
        }

        private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            volumeManagement(e);
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.PreviousSize.Width != 0 && e.PreviousSize.Height != 0)
            {
                double xRatio = e.NewSize.Width / e.PreviousSize.Width;
                double yRatio = e.NewSize.Height / e.PreviousSize.Height;
                prevVid_Button.Width *= xRatio;
                prevVid_Button.Height *= yRatio;

                nextVideo_Button.Width *= xRatio;
                nextVideo_Button.Height *= yRatio;

                videoProgress.Width *= xRatio;
                videoProgress.Height *= yRatio;

                bullshit_Button.Width *= xRatio;
                bullshit_Button.Height *= yRatio;
            }
        }

        private void Label_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            volumeManagement(e);
        }

        bool liked = false;

        private void likeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (liked)
            {
                liked = !liked;
                likeBtn.Content = LikeImage;
            }
            else
            {
                liked = !liked;
                likeBtn.Content = NotlikeImage;
            }
        }

        private async void rawLinkText_GotFocus(object sender, RoutedEventArgs e)
        {
            await Application.Current.Dispatcher.InvokeAsync((sender as TextBox).SelectAll);
        }
        
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var test = e.GetPosition(this);
            if (test.Y > 80 && test.Y < 840)
            {
                if (isPlaying)
                {
                    isPlaying = !isPlaying;
                    _mp.Pause();
                    PlayImage.Opacity = 1;
                }
                else
                {

                    isPlaying = !isPlaying;
                    _mp.Play();
                    PlayImage.Opacity = 0;
                }
            }
        }
    }
}