using LibVLCSharp.Shared;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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

        public MainWindow()
        {
            InitializeComponent();

            /* Following part is made to get libVLC DLLs, as they are not copied in main folder*/
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            string VlcLibDirectory = new DirectoryInfo(System.IO.Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64")).FullName;
            Core.Initialize(VlcLibDirectory);

            var videoURL = getNewUrl();
            Console.WriteLine(videoURL);

            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            videoView.Loaded += (sender, e) => videoView.MediaPlayer = _mp;
            _mp.Play(new Media(_libVLC, videoURL, FromType.FromLocation));
            _mp.Volume = 20;
        }

        private bool isPlaying = true;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isPlaying)
            {
                isPlaying = !isPlaying;
                _mp.Pause();
                var Image = new Image();
                var UriString = @"pack://application:,,,/TikTokForWindows;component/Resources/play-button.png";
                var UriBitmapImageSource = new Uri(UriString, UriKind.Absolute);
                var BitMapImage = new BitmapImage(UriBitmapImageSource);
                Image.Source = BitMapImage;
                playPauseBtn.Content = Image;
            }
            else
            {
                isPlaying = !isPlaying;
                _mp.Play();
                var Image = new Image();
                var UriString = @"pack://application:,,,/TikTokForWindows;component/Resources/pause-button.png";
                var UriBitmapImageSource = new Uri(UriString, UriKind.Absolute);
                var BitMapImage = new BitmapImage(UriBitmapImageSource);
                Image.Source = BitMapImage;
                playPauseBtn.Content = Image;
            }
        }
    }
}
