using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokForWindows
{
#pragma warning disable CS0169 // Supprimer les membres privés non utilisés
#pragma warning disable CS0414 // Supprimer les membres privés non utilisés

    class StaticRequestParams
    {
        /** Your Android version, e.g. 23 */
        string os_api;                               /** Your device model, e.g. Pixel 2 */
        string device_type;

        /** ??? - set to "a" */
        string ssmix;

        /** The SS_VERSION_CODE metadata value from the AndroidManifest.xml file, e.g. 2018060103 */
        string manifest_version_code;

        /** Your device's pixel density, e.g. 480 */
        int dpi;

        /** The application name - hard-coded to "musical_ly" */
        string app_name;

        /** The SS_VERSION_NAME metadata value from the AndroidManifest.xml file, e.g. 7.2.0 */
        string version_name;

        /** The UTC offset in seconds of your timezone, e.g. 37800 for Australia/Lord_Howe */
        int timezone_offset;

        /** ??? - are we in China / using the Chinese version? Set to 0 */
        int is_my_cn;

        /** Network connection type, e.g. "wifi" */
        string ac;

        /** The UPDATE_VERSION_CODE metadata value from the AndroidManifest.xml file, e.g. 2018060103 */
        string update_version_code;

        /** The channel you downloaded the app through, e.g. googleplay */
        string channel;

        /** Your device's platform, e.g. android */
        string device_platform;

        /** The build number of the application, e.g. 7.2.0 */
        string build_number;

        /** A numeric version of the version_name metadata value, e.g. 720 */
        int version_code;

        /** The name of your timezone as per the tz database, e.g. Australia/Sydney */
        string timezone_name;

        /**
         * The region of the account you are logging into, e.g. AU.
         *
         * This field is only present if you are logging in from a device that hasn't had a
         * user logged in before.
         */
        string account_region;

        /** Your device's resolution, e.g. 1080*1920 */
        string resolution;

        /** Your device's operating system version, e.g. 8.0.0 */
        string os_version;

        /** Your device's brand, e.g. Google */
        string device_brand;

        /** ??? - empty */
        string mcc_mnc;

        /** The application's two-letter language code, e.g. en */
        string app_language;

        /** Your i18n language, e.g. en */
        string language;

        /** Your region's i18n locale, e.g. US */
        string region;

        /** Your device's i18n locale, e.g. US */
        string sys_region;

        /** Your carrier's region (a two-letter country code), e.g. AU */
        string carrier_region;

        /** You carrer's mobile country code (MCC), e.g. 505 */
        string carrier_region_v2;

        /** A hard-coded i18n constant set to "1233" */
        string aid;

        /** ??? - set to 1 */
        int pass_region;

        /** ??? - set to 1 */
        int pass_route;
    }

    class UserInfo
    {
        /* LoginRequest */
        int mix_mode = 1;
        string username;
        string email;
        string mobile;
        string account;
        string password;
        string captcha;

        /* LoginSuccess */
        LoginSuccessData dataSuccess;
        LoginErrorData dataError;
        string message;

        UserInfo()
        { }

    }

    class LoginSuccessData
    {
        string area;
        string avatar_url;
        string bg_img_url;
        string birthday;
        int can_be_found_by_phone;
        //connects?!
        string description;
        string email;
        int followers_count;
        int followings_count;
        int gender;
        string industry;
        int isBlocked;
        int is_recommend_allowed;
        int media_id;
        string mobile;
        string name;
        int new_user;
        string recommend_hint_message;
        string screen_name;
        string session_key; //THIS IS IMPORTANT AS SHIT; Used as id for everything needing an account o/
        int skip_edit_profile;
        string user_auth_info;
        string user_id;
        bool user_verified;
        string verified_agency;
        string verified_content;
        int visit_count_recent;
    }

    class LoginErrorData
    {
        string captcha;
        string description;
        int error_code;
    }
}
#pragma warning restore CS0169 // Supprimer les membres privés non utilisés
#pragma warning restore CS0414 // Supprimer les membres privés non utilisés
