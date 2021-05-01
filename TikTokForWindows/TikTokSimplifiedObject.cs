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
    class TikTokSimplifiedObject
    {
        public string AuthorName { get; set; }
        public BitmapImage AuthorImage { get; set; }
        public string VideoUrl { get; set; }
        public int LikeNbr { get; set; }
        public int CommentNbr { get; set; }
        public int ShareNbr { get; set; }
        public FlowDocument VideoDesc { get; set; }

        public TikTokSimplifiedObject(AwemeStructV2 TikTokAwemeStructV2)
        {
            AuthorName = TikTokAwemeStructV2.Author.Nickname;
            var request = WebRequest.Create(TikTokAwemeStructV2.Author.AvatarMedium);
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
            LikeNbr = int.Parse(TikTokAwemeStructV2.Stats.DiggCount.ToString());
            CommentNbr = int.Parse(TikTokAwemeStructV2.Stats.CommentCount.ToString());
            ShareNbr = int.Parse(TikTokAwemeStructV2.Stats.ShareCount.ToString());
            var urlList = TikTokAwemeStructV2.Video.PlayAddr;
            VideoUrl = TikTokAwemeStructV2.Video.PlayAddr;
            /*
            for (int j = 0; j < 3; j++)
            {
                if (urlList[j].ToString().Contains("aweme"))
                {
                    VideoUrl = urlList[j].ToString();
                }
            }
            */
            VideoDesc = makeNiceDesc(TikTokAwemeStructV2.Desc);
        }

        private FlowDocument makeNiceDesc(string videoDesc)
        {
            var videoDescArr = videoDesc.Split(' ');
            Paragraph para = new Paragraph();
            foreach (var word in videoDescArr)
            {
                var mention = Regex.Match(word, @"\@[^\@\n\s]+");
                var hashtags = Regex.Match(word, @"\#[^\#\n\s]+");
                if (mention.Success)
                {
                    para.Inlines.Add(new Bold(new Run(mention.Value + " ")));
                }
                else if (hashtags.Success)
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
