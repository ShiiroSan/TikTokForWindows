using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeStructV2 {
		[ProtoMember(1)]
		public string aweme_id{ get; set; }
		[ProtoMember(2)]
		public string desc{ get; set; }
		[ProtoMember(3)]
		public long create_time{ get; set; }
		[ProtoMember(4)]
		public UserStructV2 author{ get; set; }
		[ProtoMember(5)]
		public MusicStructV2 music{ get; set; }
		[ProtoMember(6)]
		public List<ChallengeStructV2> cha_list{ get; set; }
		[ProtoMember(7)]
		public VideoStructV2 video{ get; set; }
		[ProtoMember(8)]
		public string share_url{ get; set; }
		[ProtoMember(9)]
		public int user_digged{ get; set; }
		[ProtoMember(10)]
		public AwemeStatisticsStructV2 statistics{ get; set; }
		[ProtoMember(11)]
		public AwemeStatusStructV2 status{ get; set; }
		[ProtoMember(12)]
		public string extra{ get; set; }
		[ProtoMember(13)]
		public int rate{ get; set; }
		[ProtoMember(14)]
		public List<TextExtraStructV2> text_extra{ get; set; }
		[ProtoMember(15)]
		public UrlStructV2 label_large{ get; set; }
		[ProtoMember(16)]
		public UrlStructV2 label_thumb{ get; set; }
		[ProtoMember(17)]
		public int is_top{ get; set; }
		[ProtoMember(18)]
		public UrlStructV2 label_top{ get; set; }
		[ProtoMember(19)]
		public ShareStructV2 share_info{ get; set; }
		[ProtoMember(20)]
		public UrlStructV2 label_origin_author{ get; set; }
		[ProtoMember(21)]
		public string distance{ get; set; }
		[ProtoMember(22)]
		public UrlStructV2 label_music_starter{ get; set; }
		[ProtoMember(23)]
		public UrlStructV2 label_private{ get; set; }
		[ProtoMember(24)]
		public List<AwemeLabelStructV2> video_labels{ get; set; }
		[ProtoMember(25)]
		public bool is_vr{ get; set; }
		[ProtoMember(26)]
		public string landing_page{ get; set; }
		[ProtoMember(27)]
		public bool is_ads{ get; set; }
		[ProtoMember(28)]
		public PoiStructV2 poi_info{ get; set; }
		[ProtoMember(29)]
		public int duration{ get; set; }
		[ProtoMember(30)]
		public int aweme_type{ get; set; }
		[ProtoMember(31)]
		public AwemeGDAdStructV2 gd_ad{ get; set; }
		[ProtoMember(32)]
		public RelationDynamicLableStructV2 relation_label{ get; set; }
		[ProtoMember(33)]
		public RedPacketStructV2 red_packet{ get; set; }
		[ProtoMember(34)]
		public bool is_fantasy{ get; set; }
		[ProtoMember(35)]
		public bool cmt_swt{ get; set; }
		[ProtoMember(36)]
		public List<ImageInfoStructV2> image_infos{ get; set; }
		[ProtoMember(37)]
		public AwemeRiskStructV2 risk_infos{ get; set; }
		[ProtoMember(38)]
		public bool is_relieve{ get; set; }
		[ProtoMember(39)]
		public UrlStructV2 label_friend{ get; set; }
		[ProtoMember(40)]
		public string sort_label{ get; set; }
		[ProtoMember(41)]
		public List<PositionStructV2> position{ get; set; }
		[ProtoMember(42)]
		public List<PositionStructV2> uniqid_position{ get; set; }
		[ProtoMember(43)]
		public List<CommentStructV2> comment_list{ get; set; }
		[ProtoMember(44)]
		public long author_user_id{ get; set; }
		[ProtoMember(45)]
		public int bodydance_score{ get; set; }
		[ProtoMember(46)]
		public List<string> geofencing{ get; set; }
		[ProtoMember(47)]
		public int is_hash_tag{ get; set; }
		[ProtoMember(48)]
		public bool is_pgcshow{ get; set; }
		[ProtoMember(49)]
		public string region{ get; set; }
		[ProtoMember(50)]
		public List<VideoTextStructV2> video_text{ get; set; }
		[ProtoMember(51)]
		public int vr_type{ get; set; }
		[ProtoMember(52)]
		public SpecialStickerStructV2 sp_sticker{ get; set; }
		[ProtoMember(53)]
		public string ad_schedule{ get; set; }
		[ProtoMember(54)]
		public int collect_stat{ get; set; }
		[ProtoMember(55)]
		public List<VideoTextStructV2> label_top_text{ get; set; }
		[ProtoMember(56)]
		public List<PromotionStructV2> promotions{ get; set; }
		[ProtoMember(57)]
		public string stickers{ get; set; }
		[ProtoMember(58)]
		public AwemeStructV2 forward_item{ get; set; }
		[ProtoMember(59)]
		public string forward_comment_id{ get; set; }
		[ProtoMember(60)]
		public string segment_longitudes{ get; set; }
		[ProtoMember(61)]
		public string segment_latitudes{ get; set; }
		[ProtoMember(62)]
		public string forward_item_id{ get; set; }
		[ProtoMember(63)]
		public string group_id{ get; set; }
		[ProtoMember(64)]
		public string pre_forward_id{ get; set; }
		[ProtoMember(65)]
		public bool prevent_download{ get; set; }
		[ProtoMember(66)]
		public List<PositionStructV2> nickname_position{ get; set; }
		[ProtoMember(67)]
		public List<PositionStructV2> challenge_position{ get; set; }
		[ProtoMember(68)]
		public int item_comment_settings{ get; set; }
		[ProtoMember(69)]
		public DescendantStructV2 descendants{ get; set; }
		[ProtoMember(70)]
		public string raw_ad_data{ get; set; }
		[ProtoMember(71)]
		public GameStructV2 game_info{ get; set; }
		[ProtoMember(72)]
		public MicroAppStructV2 micro_app_info{ get; set; }
		[ProtoMember(73)]
		public bool with_promotional_music{ get; set; }
		[ProtoMember(74)]
		public string link_ad_data{ get; set; }
		[ProtoMember(75)]
		public XiguaTaskStructV2 xigua_task{ get; set; }
		[ProtoMember(76)]
		public CommerceActivityStructV2 gesture_red_packet{ get; set; }
		[ProtoMember(77)]
		public CommerceActivityStructV2 activity_pendant{ get; set; }
		[ProtoMember(78)]
		public NewFaceStickerStructV2 sticker_detail{ get; set; }
		[ProtoMember(79)]
		public List<LongVideoStructV2> long_video{ get; set; }
		[ProtoMember(80)]
		public int item_duet{ get; set; }
		[ProtoMember(81)]
		public int item_react{ get; set; }
		[ProtoMember(82)]
		public AwemeSearchStructV2 hot_info{ get; set; }
		[ProtoMember(83)]
		public long star_atlas_order_id{ get; set; }
		[ProtoMember(84)]
		public string label_music_starter_text{ get; set; }
		[ProtoMember(85)]
		public bool without_watermark{ get; set; }
		[ProtoMember(86)]
		public PreloadStructV2 preload{ get; set; }
		[ProtoMember(87)]
		public string star_recommend_tag{ get; set; }
		[ProtoMember(88)]
		public string ad_order_id{ get; set; }
		[ProtoMember(89)]
		public string open_platform_name{ get; set; }
		[ProtoMember(90)]
		public AwemeStarAtlasStructV2 star_atlas_info{ get; set; }
		[ProtoMember(91)]
		public string desc_language{ get; set; }
		[ProtoMember(92)]
		public AwemeFloatingCardStructV2 floating_card_content{ get; set; }
		[ProtoMember(93)]
		public List<InteractionStickerStructV2> interaction_stickers{ get; set; }
		[ProtoMember(94)]
		public OpenPlatformStructV2 open_platform_info{ get; set; }
		[ProtoMember(95)]
		public int ad_link_type{ get; set; }
		[ProtoMember(96)]
		public int take_down_reason{ get; set; }
		[ProtoMember(97)]
		public string take_down_desc{ get; set; }
		[ProtoMember(98)]
		public string simple_promotions{ get; set; }
		[ProtoMember(99)]
		public string misc_info{ get; set; }
		[ProtoMember(100)]
		public AwemePromotionOtherStructV2 promotion_other_info{ get; set; }
		[ProtoMember(101)]
		public List<string> origin_comment_ids{ get; set; }
		[ProtoMember(102)]
		public List<CommerceConfigDataV2> commerce_config_data{ get; set; }
		[ProtoMember(103)]
		public AwemeCommerceStickerStructV2 commerce_sticker_info{ get; set; }
		[ProtoMember(104)]
		public bool enable_top_view{ get; set; }
		[ProtoMember(105)]
		public int distribute_type{ get; set; }
		[ProtoMember(106)]
		public VideoControlV2 video_control{ get; set; }
		[ProtoMember(107)]
		public int is_effect_designer{ get; set; }
		[ProtoMember(108)]
		public int ad_aweme_source{ get; set; }
		[ProtoMember(109)]
		public AwemeControlStructV2 aweme_control{ get; set; }
		[ProtoMember(110)]
		public bool has_vs_entry{ get; set; }
		[ProtoMember(111)]
		public AnchorStructV2 anchor{ get; set; }
		[ProtoMember(112)]
		public RelationLabelStructV2 feed_relation_label{ get; set; }
		[ProtoMember(113)]
		public MixStructV2 mix_info{ get; set; }
		[ProtoMember(114)]
		public string simple_shop_seeding{ get; set; }
		[ProtoMember(115)]
		public HotListStructV2 hot_list{ get; set; }
		[ProtoMember(116)]
		public AwemeCommerceStructV2 commerce_info{ get; set; }
		[ProtoMember(117)]
		public AwemeNationalTaskStructV2 national_task_info{ get; set; }
		[ProtoMember(118)]
		public BannerTipV2 banner_tip{ get; set; }
		[ProtoMember(119)]
		public AwemeACLStructV2 acl_info{ get; set; }
		[ProtoMember(121)]
		public AwemeAnchorStructV2 anchor_info{ get; set; }
		[ProtoMember(122)]
		public VPAInfoStructV2 vpa_info{ get; set; }
		[ProtoMember(123)]
		public CNYStructV2 cny_info{ get; set; }
		[ProtoMember(124)]
		public bool is_familiar{ get; set; }
		[ProtoMember(125)]
		public bool need_vs_entry{ get; set; }
		[ProtoMember(126)]
		public WebcastRoomFeedCellStructV2 cell_room{ get; set; }
		[ProtoMember(127)]
		public string live_reason{ get; set; }
		[ProtoMember(128)]
		public string video_feed_tag{ get; set; }
	}
}