using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace TikTokForWindows
{
    class TikTokManager
    {
        private static string api_url = "https://m.tiktok.com/";
        private static string aid = "1988";
        private static string app_name = "tiktok_web";
        private static string device_platform = "web";
        private static string referer = ""; //can be empty
        private static string root_referer = ""; //can be empty
        private static string user_agent = "Mozilla%2F5.0+(Windows+NT+10.0%3B+Win64%3B+x64)+AppleWebKit%2F537.36+(KHTML,+like+Gecko)+Chrome%2F90.0.4400.0+Safari%2F537.36+Edg%2F90.0.782.0";
        private static string cookie_enabled = "true";
        private static string screen_width = "1920";
        private static string screen_height = "1080";
        private static string browser_language = "fr";
        private static string browser_platform = "Win32";
        private static string browser_name = "Mozilla";
        private static string browser_version = "5.0+(Windows+NT+10.0%3B+Win64%3B+x64)+AppleWebKit%2F537.36+(KHTML,+like+Gecko)+Chrome%2F90.0.4400.0+Safari%2F537.36+Edg%2F90.0.782.0";
        private static string browser_online = "true";
        private static string ac = "4g";
        private static string timezone_name = "Europe%2FParis&priority_region=FR";
        private static string verifyFp = "verify_kkl3tqdg_qR07xqP1_cQpZ_4YeG_BnSp_HYxb1trXwR6I";
        private static string appId = "1233";
        private static string region = "FR";
        private static string appType = "m";
        private static string isAndroid = "false";
        private static string isMobile = "false";
        private static string isIOS = "false";
        private static string OS = "windows";
        private static string did = "6923895903828887045";
        private static string tt_web_region = "FR";
        private static string uid = "6696409054825464837";
        private static string count = "30";
        private static string itemID = "1";
        private static string language = "fr";
        private static string _signature = "_02B4Z6wo00f01sJKjsQAAIDAHg7ztWHlkH7CSopAANDA3b"; //don't know what's used or what's it so I'll don't care for the moment


        //StaticRequestParams staticRequestParams = new StaticRequestParams();
        // staticRequestParams.
        public static FeedResponse GetFeed()
        {
            HttpWebRequest request = WebRequest.CreateHttp($"{api_url}api/recommend/item_list/?aid={aid}&app_name={app_name}&device_platform={device_platform}&referer={referer}&root_referer={root_referer}" +
                $"&user_agent={user_agent}&cookie_enabled={cookie_enabled}&screen_width={screen_width}&screen_height={screen_height}&browser_language={browser_language}&browser_platform={browser_platform}" +
                $"&browser_name={browser_name}&browser_version={browser_version}&browser_version={browser_version}&browser_online={browser_online}&ac={ac}" +
                $"&timezone_name={timezone_name}&verifyFp={verifyFp}&appId={appId}&region={region}&appType={appType}&isAndroid={isAndroid}&isMobile={isMobile}&isIOS={isIOS}&OS={OS}&did={did}" +
                $"&tt-web-region={tt_web_region}&uid={uid}&count={count}&itemID={itemID}&language={language}");
            
            //HttpWebRequest request = WebRequest.CreateHttp($"https://m.tiktok.com/api/recommend/item_list/?aid=1988&app_name=tiktok_web&device_platform=web&referer=&root_referer=&user_agent=Mozilla%2F5.0+(Windows+NT+10.0%3B+Win64%3B+x64)+AppleWebKit%2F537.36+(KHTML,+like+Gecko)+Chrome%2F90.0.4400.0+Safari%2F537.36+Edg%2F90.0.782.0&cookie_enabled=true&screen_width=1920&screen_height=1080&browser_language=fr&browser_platform=Win32&browser_name=Mozilla&browser_version=5.0+(Windows+NT+10.0%3B+Win64%3B+x64)+AppleWebKit%2F537.36+(KHTML,+like+Gecko)+Chrome%2F90.0.4400.0+Safari%2F537.36+Edg%2F90.0.782.0&browser_online=true&ac=4g&timezone_name=Europe%2FParis&priority_region=FR&verifyFp=verify_kkl3tqdg_qR07xqP1_cQpZ_4YeG_BnSp_HYxb1trXwR6I&appId=1233&region=FR&appType=m&isAndroid=false&isMobile=false&isIOS=false&OS=windows&did=6923895903828887045&tt-web-region=FR&uid=6696409054825464837&count=30&itemID=1&language=fr");
            HttpWebResponse response;
            try
            {
                // The 3 following line is needed to bypass some check against botting on website (Error 403 if these line don't exist)
                request.Method = "GET";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4400.0 Safari/537.36 Edg/90.0.782.0";
                request.CookieContainer = new System.Net.CookieContainer();
                response = (HttpWebResponse)request.GetResponse();

                var test = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return JsonConvert.DeserializeObject<FeedResponse>(test);
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
