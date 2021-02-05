using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TikTokForWindows
{
    class TikTokManager
    {
        private static string api_url = "http://api.tiktokv.com";
        private static string api_channel = "googleplay";
        private static string api_device = "ONEPLUS%20A5000";
        private static string api_osversion = "9";
        private static string api_versioncode = "130303";
        private static string api_appname = "musical_ly";
        private static string api_plateform = "android";
        private static string api_deviceid = "6696405881771705861";

        //StaticRequestParams staticRequestParams = new StaticRequestParams();
        // staticRequestParams.
        public static aweme_v2_feed_response GetFeed()
        {
            HttpWebRequest request = WebRequest.CreateHttp($"{api_url}/aweme/v2/feed/?channel={api_channel}&device_type={api_device}&os_version={api_osversion}&version_code={api_versioncode}&app_name={api_appname}&device_platform={api_plateform}&device_id={api_deviceid}&volume=0");
            HttpWebResponse response;
            try
            {
                // The 3 following line is needed to bypass some check against botting on website (Error 403 if these line don't exist)
                request.Method = "GET";
                request.Accept = "text/html";
                request.UserAgent = "okhttp/3.10.0.1"; //okhttp seems to bypass new issues caused by 2k20 :shrug:
                response = (HttpWebResponse)request.GetResponse();

                return Serializer.Deserialize<aweme_v2_feed_response>(response.GetResponseStream());
            }
            catch (WebException e)
            {
                HttpWebResponse n = (HttpWebResponse)e.Response;
                MessageBox.Show(e.ToString()); //ADD THIS STRING FOR DEBUGGING, TO SEE IF THERE IS AN EXCEPTION.
                if (n.StatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }
            }
            return null;
        }
    }
}
