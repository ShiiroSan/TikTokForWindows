using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TikTokForWindows
{
    class TikTokVideoObject
    {
        public string AuthorName { get; set; }
        public BitmapImage AuthorImage { get; set; }
        public string VideoUrl { get; set; }
        public int LikeNbr { get; set; }
        public int CommentNbr { get; set; }
        public int ShareNbr { get; set; }
        public FlowDocument VideoDesc { get; set; }

        public TikTokVideoObject(JToken TikTokJSONElement)
        {
            AuthorName = TikTokJSONElement["author"]["nickname"].ToString();
            var request = WebRequest.Create(TikTokJSONElement["author"]["avatar_medium"]["url_list"][0].ToString());
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                if (response.ContentType != "image/webp")
                {

                    AuthorImage = Convert(System.Drawing.Image.FromStream(stream));
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        Bitmap webpConverted = new Imazen.WebP.SimpleDecoder().DecodeFromBytes(ms.ToArray(), ms.Length);
                        AuthorImage = Convert(webpConverted);
                    }

                }
            }
            LikeNbr = int.Parse(TikTokJSONElement["statistics"]["digg_count"].ToString());
            CommentNbr = int.Parse(TikTokJSONElement["statistics"]["comment_count"].ToString());
            ShareNbr = int.Parse(TikTokJSONElement["statistics"]["share_count"].ToString());
            var urlList = TikTokJSONElement["video"]["play_addr"]["url_list"];
            for (int j = 0; j < 3; j++)
            {
                if (urlList[j].ToString().Contains("api2.musical.ly"))
                {
                    VideoUrl = urlList[j].ToString();
                }
            }
            VideoDesc = makeNiceDesc(TikTokJSONElement["desc"].ToString());
        }

        private FlowDocument makeNiceDesc(string videoDesc)
        {
            var videoDescArr = videoDesc.Split(' ');
            Paragraph para = new Paragraph();
            foreach (var word in videoDescArr)
            {
                var hashtags = Regex.Match(word, @"\#[^\#\n\s]+");
                if (hashtags.Success)
                {
                    para.Inlines.Add(new Run(hashtags.Value + " ")
                    {
                        Foreground = System.Windows.Media.Brushes.Blue
                    });
                }
                else
                {
                    para.Inlines.Add(word + " ");
                }
            }
            FlowDocument flowDocument = new FlowDocument();
            flowDocument.Blocks.Add(para);
            return flowDocument;

        }

        /*Source: 
         * James Ramsden at http://james-ramsden.com/c-convert-image-bitmapimage/
         */
        private BitmapImage Convert(System.Drawing.Image img)
        {
            using (var memory = new MemoryStream())
            {
                img.Save(memory, ImageFormat.Png);
                memory.Position = 0;

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }
    }
}
