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


        List<TikTokVideoObject> listOfVids;
        int positionOfUrlsList = -1;

        List<TikTokVideoObject> getNewVids()
        {
            List<TikTokVideoObject> listOfVids = new List<TikTokVideoObject>();
            var m_jsonTikTokFeed = GetTikTokShit.GetFeed();
            /*
            for (int i = 0; i < m_jsonTikTokFeed["aweme_list"].Count(); i++)
            {
                listOfVids.Add(new TikTokVideoObject(m_jsonTikTokFeed["aweme_list"][i]));
            }
            */
            return listOfVids;
        }

        TikTokVideoObject getPrevVid()
        {
            positionOfUrlsList--;
            if (positionOfUrlsList < 0)
            {
                listOfVids.Clear();
                listOfVids.AddRange(getNewVids()); //This is to reproduce when you do random search on foryou page
                positionOfUrlsList = 0;
            }
            return listOfVids[positionOfUrlsList];
        }

        TikTokVideoObject getNewVid()
        {
            positionOfUrlsList++;
            if (positionOfUrlsList == listOfVids.Count)
            {
                listOfVids.AddRange(getNewVids());
            }
            return listOfVids[positionOfUrlsList];
        }


        Image PlayImage;
        Image PauseImage;

        BitmapImage PlayBitmapImage;
        BitmapImage PauseBitmapImage;


        string videoURL;

        DateTime volumeTimer = new DateTime();
        Thread volumeThread;

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
                ThreadPool.QueueUserWorkItem(_ => volumeLabel.Dispatcher.Invoke(() => volumeLabel.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(alphaVal, 255, 255, 255))));
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

            listOfVids = getNewVids();
            var newVid = getNewVid();
            videoURL = newVid.VideoUrl;
            authorImage.Source = newVid.AuthorImage;
            Console.WriteLine(videoURL);

            _libVLC = new LibVLC("--verbose=2");
            _mp = new MediaPlayer(_libVLC);
            videoView.Loaded += (sender, e) => videoView.MediaPlayer = _mp;

            _mp.Volume = 30;
            volumeSlider.Value = _mp.Volume;

            _mp.Play(new Media(_libVLC, "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4", FromType.FromLocation));
            //_mp.Play(new Media(_libVLC, videoURL, FromType.FromLocation));

            _mp.TimeChanged += TimeChanged;
            _mp.EndReached += EndReached;
            _mp.VolumeChanged += VolumeChanged;

            PlayImage = new Image();
            var UriStringPlay = @"pack://application:,,,/TikTokForWindows;component/Resources/play-button.png";
            var UriBitmapImageSourcePlay = new Uri(UriStringPlay, UriKind.Absolute);
            PlayBitmapImage = new BitmapImage(UriBitmapImageSourcePlay);
            PlayImage.Source = PlayBitmapImage;

            PauseImage = new Image();
            var UriStringPause = @"pack://application:,,,/TikTokForWindows;component/Resources/pause-button.png";
            var UriBitmapImageSourcePause = new Uri(UriStringPause, UriKind.Absolute);
            PauseBitmapImage = new BitmapImage(UriBitmapImageSourcePause);
            PauseImage.Source = PauseBitmapImage;
        }

        private bool isPlaying = true;

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
                    _mp.Volume += 10;
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
                    _mp.Volume -= 10;
                }
            }

        }

        private string NormalizeNumber(int numberToNormalize)
        {
            if (numberToNormalize > 1000 && numberToNormalize < 1000000)
            {
                float reducedNumber = (float)numberToNormalize / 1000;
                if (reducedNumber > 99)
                {
                    return (int)reducedNumber + "K";
                }
                if (reducedNumber > 9 && reducedNumber < 100)
                {
                    return reducedNumber.ToString("##.#") + "K";
                }
                if (reducedNumber > 0 && reducedNumber < 10)
                {
                    return reducedNumber.ToString("#.##") + "K";
                }
            }
            return numberToNormalize.ToString();
        }

        /*
         * GUI MANAGEMENT
         */

        private void playPause_Click(object sender, RoutedEventArgs e)
        {
            if (isPlaying)
            {
                isPlaying = !isPlaying;
                _mp.Pause();
                playPauseBtn.Content = PlayImage;
            }
            else
            {

                isPlaying = !isPlaying;
                _mp.Play();
                playPauseBtn.Content = PauseImage;
            }
        }

        private void nextVideo_Click(object sender, RoutedEventArgs e)
        {
            var newVid = getNewVid();

            videoURL = newVid.VideoUrl;
            authorImage.Source = newVid.AuthorImage;
            authorNameLabel.Content = newVid.AuthorName;
            videoDescriptionLabel.Document = newVid.VideoDesc;
            likeNbrLabel.Content = NormalizeNumber(newVid.LikeNbr);
            commentNbrLabel.Content = NormalizeNumber(newVid.CommentNbr);
            shareNbrLabel.Content = NormalizeNumber(newVid.ShareNbr);
            Console.WriteLine(videoURL);
            _mp.Play(new Media(_libVLC, videoURL, FromType.FromLocation));
        }

        private void prevVid_Click(object sender, RoutedEventArgs e)
        {
            videoURL = getPrevVid().VideoUrl;
            var prevVid = getPrevVid();

            videoURL = prevVid.VideoUrl;
            authorImage.Source = prevVid.AuthorImage;
            authorNameLabel.Content = prevVid.AuthorName;
            videoDescriptionLabel.Document = prevVid.VideoDesc;
            likeNbrLabel.Content = NormalizeNumber(prevVid.LikeNbr);
            commentNbrLabel.Content = NormalizeNumber(prevVid.CommentNbr);
            shareNbrLabel.Content = NormalizeNumber(prevVid.ShareNbr);
            Console.WriteLine(videoURL);
            _mp.Play(new Media(_libVLC, videoURL, FromType.FromLocation));
        }

        /*
         * EVENT MANAGEMENT
         */

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

                playPauseBtn.Width *= xRatio;
                playPauseBtn.Height *= yRatio;

                nextVideo_Button.Width *= xRatio;
                nextVideo_Button.Height *= yRatio;

                videoProgress.Width *= xRatio;
                videoProgress.Height *= yRatio;
            }
        }
    }
}
