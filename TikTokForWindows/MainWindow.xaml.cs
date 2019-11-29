using LibVLCSharp.Shared;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
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
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LibVLC _libVLC;
        private MediaPlayer _mp;


        string getNewUrl()
        {
            string m_sTiktokfeed = GetTikTokShit.GetFeed();
            JObject m_jsonTikTokFeed = JObject.Parse(m_sTiktokfeed);
            string var1 = m_jsonTikTokFeed["aweme_list"][0]["video"]["play_addr"]["url_list"][0].ToString();
            //string url = Regex.Replace(var1[0]["video"]["play_addr"]["url_list"][0].ToString(), @"\""", @"");
            return var1;
        }

        Image PlayImage;
        Image PauseImage;

        BitmapImage PlayBitmapImage;
        BitmapImage PauseBitmapImage;

        string videoURL;

        public MainWindow()
        {
            InitializeComponent();
            TikTokLogin.XorEncrypt("password");

            /* Following part is made to get libVLC DLLs, as they are not copied in main folder*/
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            string VlcLibDirectory = new DirectoryInfo(System.IO.Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64")).FullName;
            Core.Initialize(VlcLibDirectory);

            videoURL = getNewUrl();
            Console.WriteLine(videoURL);

            _libVLC = new LibVLC();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isPlaying)
            {
                isPlaying = !isPlaying;
                _mp.Pause();
                playPauseBtn.Content = PauseImage;
            }
            else
            {

                isPlaying = !isPlaying;

                if (b_hasEnded)
                {
                    b_hasEnded = !b_hasEnded;
                    _mp.Play(new Media(_libVLC, videoURL, FromType.FromLocation));
                }
                _mp.Play();
                playPauseBtn.Content = PlayImage;
            }
        }

        private void nextVideo_Click(object sender, RoutedEventArgs e)
        {
            videoURL = getNewUrl();
            Console.WriteLine(videoURL);
            //_mp.Stop();
            //_mp.Play(new Media(_libVLC, videoURL, FromType.FromLocation));
        }

        private void TimeChanged(object sender, System.EventArgs e)
        {
            videoProgress.Dispatcher.Invoke(() => videoProgress.Value = _mp.Time * 100 / _mp.Length); //Dispatcher.Invoke is used to modify element form within another thread
        }

        bool b_hasEnded;

        private void EndReached(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            b_hasEnded = true;
            playPauseBtn.Dispatcher.Invoke(() => playPauseBtn.Content = PlayImage);
            videoProgress.Dispatcher.Invoke(() => videoProgress.Value = 100);
        }
    }
}
