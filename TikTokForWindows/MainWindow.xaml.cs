using LibVLCSharp.Shared;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xamarin.Forms.Xaml;
using Image = System.Windows.Controls.Image;
using MediaPlayer = LibVLCSharp.Shared.MediaPlayer;

namespace TikTokForWindows
{
    public partial class MainWindow : Window
    {
        private LibVLC _libVLC;
        private MediaPlayer _mp;


        List<string> listOfUrls;
        int positionOfUrlsList = -1;

        List<string> getNewUrls()
        {
            List<string> listOfUrl = new List<string>();
            string m_sTiktokfeed = GetTikTokShit.GetFeed();
            JObject m_jsonTikTokFeed = JObject.Parse(m_sTiktokfeed);
            JToken awemeListJSON = m_jsonTikTokFeed["aweme_list"];

            for (int i = 0; i < awemeListJSON.Count(); i++)
            {
                listOfUrl.Add(m_jsonTikTokFeed["aweme_list"][i]["video"]["play_addr"]["url_list"][0].ToString());
            }
            //string url = Regex.Replace(var1[0]["video"]["play_addr"]["url_list"][0].ToString(), @"\""", @"");
            return listOfUrl;
        }

        string getPrevUrl()
        {
            positionOfUrlsList--;
            if (positionOfUrlsList < 0)
            {
                listOfUrls.Clear();
                listOfUrls.AddRange(getNewUrls()); //This is to reproduce when you do random search on foryou page
                positionOfUrlsList = 0;
            }
            return listOfUrls[positionOfUrlsList];
        }

        string getNewUrl()
        {
            positionOfUrlsList++;
            if (positionOfUrlsList == listOfUrls.Count)
            {
                listOfUrls.AddRange(getNewUrls());
            }
            return listOfUrls[positionOfUrlsList];
        }


        Image PlayImage;
        Image PauseImage;

        BitmapImage PlayBitmapImage;
        BitmapImage PauseBitmapImage;


        string videoURL;

        public MainWindow()
        {
            InitializeComponent();
            //TikTokLogin.XorEncrypt("password");
            /* Following part is made to get libVLC DLLs, as they are not copied in main folder*/
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            string VlcLibDirectory = new DirectoryInfo(System.IO.Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64")).FullName;
            Core.Initialize(VlcLibDirectory);

            listOfUrls = getNewUrls();

            videoURL = getNewUrl();
            Console.WriteLine(videoURL);

            _libVLC = new LibVLC("--verbose=2");
            _mp = new MediaPlayer(_libVLC);
            videoView.Loaded += (sender, e) => videoView.MediaPlayer = _mp;
            _mp.Play(new Media(_libVLC, videoURL, FromType.FromLocation));
            _mp.Volume = 30;

            _mp.TimeChanged += TimeChanged;
            _mp.EndReached += EndReached;

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
            videoURL = getNewUrl();
            Console.WriteLine(videoURL);
            _mp.Play(new Media(_libVLC, videoURL, FromType.FromLocation));
        }

        private void prevVid_Click(object sender, RoutedEventArgs e)
        {
            videoURL = getPrevUrl();
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
    }
}
