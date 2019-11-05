using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTokForWindows
{
    public partial class PageDisplayForm : Form
    {
        string getNewUrl()
        {
            string m_sTiktokfeed = GetTikTokShit.GetFeed();
            JObject m_jsonTikTokFeed = JObject.Parse(m_sTiktokfeed);
            JToken var1 = m_jsonTikTokFeed["aweme_list"];
            string url = Regex.Replace(var1[0]["video"]["play_addr"]["url_list"][0].ToString(), @"\""", @"");
            return url;
        }

        public PageDisplayForm()
        {
            InitializeComponent();
            string url = getNewUrl();
            geckoWebBrowser1.Navigate(url);
        }

        private void GetNewVideo_Click(object sender, EventArgs e)
        {
            string url = getNewUrl();
            geckoWebBrowser1.Navigate(url);
        }
    }
}
