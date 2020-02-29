using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows
{
    [ProtoContract]
    class UserStructV2
    {
        [ProtoMember(1)]
        public string uid { get; set; }
        [ProtoMember(2)]
        public string short_id { get; set; }
        [ProtoMember(3)]
        public string nickname { get; set; }
        [ProtoMember(4)]
        public int gender { get; set; }
        [ProtoMember(5)]
        public string signature { get; set; }
        [ProtoMember(6)]
        public UrlStructV2 avatar_larger { get; set; }
        [ProtoMember(7)]
        public UrlStructV2 avatar_thumb { get; set; }
        [ProtoMember(8)]
        public UrlStructV2 avatar_medium { get; set; }
        [ProtoMember(9)]
        public string birthday { get; set; }
        [ProtoMember(10)]
        public bool is_verified { get; set; }
        [ProtoMember(11)]
        public int allow_status { get; set; }
        [ProtoMember(12)]
        public int follow_status { get; set; }
        [ProtoMember(13)]
        public int aweme_count { get; set; }
        [ProtoMember(14)]
        public int following_count { get; set; }
        [ProtoMember(15)]
        public int follower_count { get; set; }
        [ProtoMember(16)]
        public int favoriting_count { get; set; }
        [ProtoMember(17)]
        public int total_favorited { get; set; }
        [ProtoMember(18)]
        public bool is_block { get; set; }
        [ProtoMember(19)]
        public string third_name { get; set; }
        [ProtoMember(20)]
        public bool hide_search { get; set; }
        [ProtoMember(21)]
        public int constellation { get; set; }
        [ProtoMember(22)]
        public string location { get; set; }
        [ProtoMember(23)]
        public bool hide_location { get; set; }
        [ProtoMember(24)]
        public string weibo_verify { get; set; }
        [ProtoMember(25)]
        public string custom_verify { get; set; }
        [ProtoMember(26)]
        public string unique_id { get; set; }
        [ProtoMember(27)]
        public string bind_phone { get; set; }
        [ProtoMember(28)]
        public int special_lock { get; set; }
        [ProtoMember(29)]
        public int need_recommend { get; set; }
        [ProtoMember(30)]
        public bool is_binded_weibo { get; set; }
        [ProtoMember(31)]
        public string weibo_name { get; set; }
        [ProtoMember(32)]
        public string weibo_schema { get; set; }
        [ProtoMember(33)]
        public string weibo_url { get; set; }
        [ProtoMember(34)]
        public bool story_open { get; set; }
        [ProtoMember(35)]
        public int story_count { get; set; }
        [ProtoMember(36)]
        public string recommend_reason { get; set; }
        [ProtoMember(37)]
        public bool has_facebook_token { get; set; }
        [ProtoMember(38)]
        public bool has_twitter_token { get; set; }
        [ProtoMember(39)]
        public int fb_expire_time { get; set; }
        [ProtoMember(40)]
        public int tw_expire_time { get; set; }
        [ProtoMember(41)]
        public bool has_youtube_token { get; set; }
        [ProtoMember(42)]
        public int youtube_expire_time { get; set; }
        [ProtoMember(43)]
        public long room_id { get; set; }
        [ProtoMember(44)]
        public int live_verify { get; set; }
        [ProtoMember(45)]
        public long authority_status { get; set; }
        [ProtoMember(46)]
        public string verify_info { get; set; }
        [ProtoMember(47)]
        public int shield_follow_notice { get; set; }
        [ProtoMember(48)]
        public int shield_digg_notice { get; set; }
        [ProtoMember(49)]
        public int shield_comment_notice { get; set; }
        [ProtoMember(50)]
        public string school_name { get; set; }
        [ProtoMember(51)]
        public string school_poi_id { get; set; }
        [ProtoMember(52)]
        public int school_type { get; set; }
        [ProtoMember(53)]
        public ShareStructV2 share_info { get; set; }
        [ProtoMember(54)]
        public bool with_commerce_entry { get; set; }
        [ProtoMember(55)]
        public int verification_type { get; set; }
        [ProtoMember(56)]
        public OriginalMusicianStructV2 original_musician { get; set; }
        [ProtoMember(57)]
        public ActivityStructV2 activity { get; set; }
        [ProtoMember(58)]
        public string enterprise_verify_reason { get; set; }
        [ProtoMember(59)]
        public bool is_ad_fake { get; set; }
        [ProtoMember(60)]
        public bool star_use_new_download { get; set; }
        [ProtoMember(61)]
        public int mplatform_followers_count { get; set; }
        [ProtoMember(62)]
        public List<FollowersDetailV2> followers_detail { get; set; }
        [ProtoMember(63)]
        public bool has_activity_medal { get; set; }
        [ProtoMember(64)]
        public string region { get; set; }
        [ProtoMember(65)]
        public string account_region { get; set; }
        [ProtoMember(66)]
        public int sync_to_toutiao { get; set; }
        [ProtoMember(67)]
        public int commerce_user_level { get; set; }
        [ProtoMember(68)]
        public CommerceInfoStructV2 commerce_info { get; set; }
        [ProtoMember(69)]
        public int live_agreement { get; set; }
        [ProtoMember(70)]
        public List<PlatformSyncStatusStructV2> platform_sync_info { get; set; }
        [ProtoMember(71)]
        public bool with_shop_entry { get; set; }
        [ProtoMember(72)]
        public bool is_discipline_member { get; set; }
        [ProtoMember(73)]
        public int secret { get; set; }
        [ProtoMember(74)]
        public bool has_orders { get; set; }
        [ProtoMember(75)]
        public bool prevent_download { get; set; }
        [ProtoMember(76)]
        public bool show_image_bubble { get; set; }
        [ProtoMember(77)]
        public List<string> geofencing { get; set; }
        [ProtoMember(78)]
        public int unique_id_modify_time { get; set; }
        [ProtoMember(79)]
        public UrlStructV2 video_icon { get; set; }
        [ProtoMember(80)]
        public string ins_id { get; set; }
        [ProtoMember(81)]
        public string google_account { get; set; }
        [ProtoMember(82)]
        public string youtube_channel_id { get; set; }
        [ProtoMember(83)]
        public string youtube_channel_title { get; set; }
        [ProtoMember(84)]
        public int apple_account { get; set; }
        [ProtoMember(85)]
        public bool with_dou_entry { get; set; }
        [ProtoMember(86)]
        public bool with_fusion_shop_entry { get; set; }
        [ProtoMember(87)]
        public bool is_phone_binded { get; set; }
        [ProtoMember(88)]
        public int login_platform { get; set; }
        [ProtoMember(89)]
        public bool accept_private_policy { get; set; }
        [ProtoMember(90)]
        public int realname_verify_status { get; set; }
        [ProtoMember(91)]
        public string twitter_id { get; set; }
        [ProtoMember(92)]
        public string twitter_name { get; set; }
        [ProtoMember(93)]
        public bool user_canceled { get; set; }
        [ProtoMember(94)]
        public bool has_email { get; set; }
        [ProtoMember(95)]
        public bool is_gov_media_vip { get; set; }
        [ProtoMember(96)]
        public int dongtai_count { get; set; }
        [ProtoMember(97)]
        public int live_agreement_time { get; set; }
        [ProtoMember(98)]
        public long register_time { get; set; }
        [ProtoMember(99)]
        public int status { get; set; }
        [ProtoMember(100)]
        public bool with_douplus_entry { get; set; }
        [ProtoMember(101)]
        public long create_time { get; set; }
        [ProtoMember(102)]
        public string avatar_uri { get; set; }
        [ProtoMember(103)]
        public int follower_status { get; set; }
        [ProtoMember(104)]
        public int neiguang_shield { get; set; }
        [ProtoMember(105)]
        public int comment_setting { get; set; }
        [ProtoMember(106)]
        public int duet_setting { get; set; }
        [ProtoMember(107)]
        public long reflow_page_gid { get; set; }
        [ProtoMember(108)]
        public long reflow_page_uid { get; set; }
        [ProtoMember(109)]
        public int user_rate { get; set; }
        [ProtoMember(110)]
        public bool with_new_goods { get; set; }
        [ProtoMember(111)]
        public bool is_flowcard_member { get; set; }
        [ProtoMember(112)]
        public UrlStructV2 room_cover { get; set; }
        [ProtoMember(113)]
        public int download_setting { get; set; }
        [ProtoMember(114)]
        public long download_prompt_ts { get; set; }
        [ProtoMember(115)]
        public int react_setting { get; set; }
        [ProtoMember(116)]
        public bool live_commerce { get; set; }
        [ProtoMember(117)]
        public string college_name { get; set; }
        [ProtoMember(118)]
        public string enroll_year { get; set; }
        [ProtoMember(119)]
        public string country { get; set; }
        [ProtoMember(120)]
        public string province { get; set; }
        [ProtoMember(121)]
        public string city { get; set; }
        [ProtoMember(122)]
        public List<UrlStructV2> cover_url { get; set; }
        [ProtoMember(123)]
        public string recommend_reason_relation { get; set; }
        [ProtoMember(124)]
        public string iso_country_code { get; set; }
        [ProtoMember(125)]
        public int show_gender_strategy { get; set; }
        [ProtoMember(126)]
        public string district { get; set; }
        [ProtoMember(127)]
        public string language { get; set; }
        [ProtoMember(128)]
        public string room_type_tag { get; set; }
        [ProtoMember(129)]
        public int dou_plus_share_location { get; set; }
        [ProtoMember(130)]
        public bool has_insights { get; set; }
        [ProtoMember(131)]
        public string remark_name { get; set; }
        [ProtoMember(132)]
        public string video_icon_virtual_URI { get; set; }
        [ProtoMember(133)]
        public string share_qrcode_uri { get; set; }
        [ProtoMember(134)]
        public int profile_tab_type { get; set; }
        [ProtoMember(135)]
        public AvatarDecorationStructV2 avatar_decoration { get; set; }
        [ProtoMember(136)]
        public bool watch_status { get; set; }
        [ProtoMember(137)]
        public bool with_commerce_newbie_task { get; set; }
        [ProtoMember(138)]
        public bool with_item_commerce_entry { get; set; }
        [ProtoMember(139)]
        public int star_billboard_rank { get; set; }
        [ProtoMember(140)]
        public int education { get; set; }
        [ProtoMember(141)]
        public bool can_modify_school_info { get; set; }
        [ProtoMember(142)]
        public int school_visible { get; set; }
        [ProtoMember(143)]
        public UrlStructV2 avatar_pendant_larger { get; set; }
        [ProtoMember(144)]
        public UrlStructV2 avatar_pendant_thumb { get; set; }
        [ProtoMember(145)]
        public UrlStructV2 avatar_pendant_medium { get; set; }
        [ProtoMember(146)]
        public List<RecommendItemStructV2> item_list { get; set; }
        [ProtoMember(147)]
        public int user_mode { get; set; }
        [ProtoMember(148)]
        public int user_period { get; set; }
        [ProtoMember(149)]
        public bool is_effect_artist { get; set; }
        [ProtoMember(150)]
        public EffectArtistStructV2 effect_detail { get; set; }
        [ProtoMember(151)]
        public CommercePermissionStructV2 commerce_permissions { get; set; }
        [ProtoMember(152)]
        public LifeStoryBlockStructV2 life_story_block { get; set; }
        [ProtoMember(153)]
        public int hide_following_follower_list { get; set; }
        [ProtoMember(154)]
        public bool has_unread_story { get; set; }
        [ProtoMember(155)]
        public List<UrlStructV2> new_story_cover { get; set; }
        [ProtoMember(156)]
        public int user_story_count { get; set; }
        [ProtoMember(157)]
        public bool has_story { get; set; }
        [ProtoMember(158)]
        public bool is_star { get; set; }
        [ProtoMember(159)]
        public DouplusToastStructV2 douplus_toast { get; set; }
        [ProtoMember(160)]
        public string cv_level { get; set; }
        [ProtoMember(161)]
        public int creator_level { get; set; }
        [ProtoMember(162)]
        public bool is_mirror { get; set; }
        [ProtoMember(163)]
        public int pr_exempt { get; set; }
        [ProtoMember(164)]
        public List<long> type_label { get; set; }
        [ProtoMember(165)]
        public long avatar_decoration_id { get; set; }
        [ProtoMember(166)]
        public bool with_luban_entry { get; set; }
        [ProtoMember(167)]
        public List<UrlStructV2> ad_cover_url { get; set; }
        [ProtoMember(168)]
        public AdCoverTitleV2 ad_cover_title { get; set; }
        [ProtoMember(169)]
        public string ad_order_id { get; set; }
        [ProtoMember(170)]
        public RFansGroupInfoV2 r_fans_group_info { get; set; }
        [ProtoMember(171)]
        public bool with_commerce_enterprise_tab_entry { get; set; }
        [ProtoMember(172)]
        public LiveHonorStructV2 honor_info { get; set; }
        [ProtoMember(173)]
        public int comment_filter_status { get; set; }
        [ProtoMember(174)]
        public int notify_private_account { get; set; }
        [ProtoMember(175)]
        public UrlStructV2 avatar_168x168 { get; set; }
        [ProtoMember(176)]
        public UrlStructV2 avatar_300x300 { get; set; }
        [ProtoMember(177)]
        public bool is_blocked { get; set; }
        [ProtoMember(178)]
        public bool force_private_account { get; set; }
        [ProtoMember(179)]
        public bool with_star_atlas_entry { get; set; }
        [ProtoMember(180)]
        public HotsearchSprintStructV2 sprint_support_user_info { get; set; }
        [ProtoMember(181)]
        public string signature_language { get; set; }
        [ProtoMember(182)]
        public BlueVBrandInfoStructV2 brand_info { get; set; }
        [ProtoMember(183)]
        public bool display_wvalantine_activity_entry { get; set; }
        [ProtoMember(184)]
        public string shop_micro_app { get; set; }
        [ProtoMember(185)]
        public CommerceUserStructV2 commerce_user_info { get; set; }
        [ProtoMember(186)]
        public List<RelativeUserStructV2> relative_users { get; set; }
        [ProtoMember(187)]
        public QuickShopStructV2 quick_shop_info { get; set; }
        [ProtoMember(188)]
        public string relation_label { get; set; }
        [ProtoMember(189)]
        public List<ChallengeStructV2> cha_list { get; set; }
        [ProtoMember(190)]
        public bool is_minor { get; set; }
        [ProtoMember(191)]
        public string sec_uid { get; set; }
        [ProtoMember(192)]
        public double recommend_score { get; set; }
        [ProtoMember(193)]
        public int wx_tag { get; set; }
        [ProtoMember(194)]
        public long open_insight_time { get; set; }
        [ProtoMember(195)]
        public PermissionStructV2 general_permission { get; set; }
        [ProtoMember(196)]
        public int birthday_hide_level { get; set; }
        [ProtoMember(197)]
        public string bio_url { get; set; }
        [ProtoMember(198)]
        public string bio_email { get; set; }
        [ProtoMember(199)]
        public long latest_order_time { get; set; }
        [ProtoMember(200)]
        public bool is_pro_account { get; set; }
        [ProtoMember(201)]
        public bool with_stick_entry { get; set; }
        [ProtoMember(202)]
        public string email { get; set; }
        [ProtoMember(203)]
        public bool is_email_verified { get; set; }
        [ProtoMember(204)]
        public string bio_secure_url { get; set; }
        [ProtoMember(205)]
        public int collect_count { get; set; }
        [ProtoMember(206)]
        public bool nickname_update_reminder { get; set; }
        [ProtoMember(207)]
        public bool avatar_update_reminder { get; set; }
        [ProtoMember(208)]
        public bool is_activity_user { get; set; }
        [ProtoMember(209)]
        public string room_data { get; set; }
    }
}