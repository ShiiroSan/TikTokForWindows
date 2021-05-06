using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokForWindows
{
    class TikTokArgumentManager
    {
    }

    class FeedArgument : TikTokArgumentManager
    {

        /** ??? - -1 **/
        private static int sp;

        /** ??? - 0 **/
        private static int type;

        /** timestamp in ms linked to last result **/ 
        private static int max_cursor;

        /** timestamp in ms linked to first result **/
        private static int min_cursor;

        /** Number of result to return **/
        private static int count; 

        /** Device's current volume from 0 to 1. One dec **/
        private static float volume; 

        /** Feed types requested **/
        private static int pull_type; 

        /** ??? - empty **/
        private static string req_from;

        /** ??? **/
        private static string gaid;

        /** user agent for the device **/
        private static string ad_user_agent;

        /** ??? - 0 **/
        private static int filter_warn;

        /** ??? - 0 **/
        private static int ad_personality_mode;

        /** ??? - 2 **/
        private static int address_book_access;

        /** ??? - empty **/
        private static string preload_aweme_ids;

        /** number of item list cached **/
        private static int cached_item_num;

        /** last ad seen counted by video seen
         * Maybe not yet implemented with my tiktok version analysis, seems to be -1
         **/
        private static int last_ad_show_interval;

        /** ??? - 1 **/
        private static int vpa_content_choice;

        /** which device is used to play the sound
         * 0 - speaker?
         **/
        private static int sound_output_device;

        /** ??? - AgMEAglAhhYX5E-wjNCCKe-mHTz6b0i25o9_hBBg-bzO **/
        private static string cmpl_enc;

        /** ???
         * Empty, sometimes?
         **/
        private static string af_params;

        /** size of avatar to show it on the mobile GUI - 96x96 **/
        private static string user_avatar_shrink;

        /** Android's device numerical version **/
        private static int os_api;

        /** Device model **/
        private static string device_type;

        /** ??? - a **/
        private static string ssmix;

        /** SS_VERSION_CODE from AndroidManifest.xml file **/
        private static string manifest_version_code;

        /** Device's DPI **/
        private static int dpi;

        /** ??? - 0 **/
        private static int uoo;

        /** Device's carrier's region in two letter **/
        private static string carrier_region;

        /** Device's region's language **/
        private static string region;

        /** Device's carrier's MCC **/
        private static string carrier_region_v2;

        /** app name, hardcoded to musical_ly **/
        private static string app_name;

        /** TikTok app version **/
        private static string version_name;

        /** UTC offset timezone in seconds **/
        private static int timezone_offset;

        /** Current timestamp since UNIX epoch (in sec) **/
        private static int ts;

        /** ??? - Same value as app_version (?) **/
        private static string ab_version;

        /** ??? - Supposedly where you bought the phone from? **/
        private static string residence;

        /** Does CPU support x64 **/
        private static bool cpu_support64;

        /** Region you're in (two letters) **/
        private static string current_region;

        /** Network connectivity type **/
        private static string ac2;

        /** ??? - supposedly china version or normal. Fixed to normal **/
        private static string app_type;

        /** Network connectivity type **/
        private static string ac;

        /** Device's ABI host **/
        private static string host_abi;

        /** Same as manifest_version_code **/
        private static string update_version_code;

        /** Where update comes from **/
        private static string channel;

        /** Current timestamp since UNIX epoch (in millisec) **/
        private static int _rticket;

        /** Device's plateform **/
        private static string device_plateform;

        /** 16 char ID based on installation **/
        private static string iid;

        /** Same as version name **/
        private static string build_number;

        /** Language device's used **/
        private static string locale;

        /** Numeric version of version_name **/
        private static int version_code;

        /** Name of your timezone **/
        private static string timezone_name;

        /** ??? **/
        private static string cdid;

        /** 16 char hex id of your device **/
        private static string openudid;

        /** Language device's used **/
        private static string sys_region;

        /** Device id made at registration **/
        private static string device_id;

        /** Language app uses **/
        private static string app_language;

        /** Device's resolution **/
        private static string resolution;

        /** Device's OS version **/
        private static string ov_version;

        /** Your language **/
        private static string language;

        /** Device's brand **/
        private static string device_brand;

        /** ??? - hardcoded to 1233 **/
        private static string aid;
    }
}
