using LibVLCSharp.Shared;
using Microsoft.DirectX.AudioVideoPlayback;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTokForWindows
{
    public partial class PageDisplayForm : Form
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

        public PageDisplayForm()
        {
            InitializeComponent();

            /* Following part is made to get libVLC DLLs, as they are not copied in main folder*/
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            string VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64")).FullName;
            Core.Initialize(VlcLibDirectory);

            var videoURL = getNewUrl();
            Console.WriteLine($"Video link: {videoURL}");

            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mp;
            _mp.Play(new Media(_libVLC, videoURL, FromType.FromLocation));
            _mp.Volume = 20;
        }

        private void PageDisplayForm_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            if (button1.Bounds.Contains(e.Location) && !button1.Visible)
            {
                button1.Show();
            }
            */
        }

    }
}
