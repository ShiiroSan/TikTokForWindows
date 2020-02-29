using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class ChallengeStructV2 {
		[ProtoMember(1)]
		public string cid{ get; set; }
		[ProtoMember(2)]
		public string cha_name{ get; set; }
		[ProtoMember(3)]
		public string desc{ get; set; }
		[ProtoMember(4)]
		public string schema{ get; set; }
		[ProtoMember(5)]
		public UserStructV2 author{ get; set; }
		[ProtoMember(6)]
		public int user_count{ get; set; }
		[ProtoMember(7)]
		public ShareStructV2 share_info{ get; set; }
		[ProtoMember(8)]
		public List<MusicStructV2> connect_music{ get; set; }
		[ProtoMember(9)]
		public int type{ get; set; }
		[ProtoMember(10)]
		public string use_count_desc{ get; set; }
		[ProtoMember(11)]
		public int sub_type{ get; set; }
		[ProtoMember(12)]
		public UrlStructV2 background_image_url{ get; set; }
		[ProtoMember(13)]
		public string sticker_id{ get; set; }
		[ProtoMember(14)]
		public string link_text{ get; set; }
		[ProtoMember(15)]
		public string link_action{ get; set; }
		[ProtoMember(16)]
		public bool is_pgcshow{ get; set; }
		[ProtoMember(17)]
		public int collect_stat{ get; set; }
		[ProtoMember(18)]
		public UrlStructV2 cover_item{ get; set; }
		[ProtoMember(19)]
		public int is_challenge{ get; set; }
		[ProtoMember(20)]
		public long view_count{ get; set; }
		[ProtoMember(21)]
		public DisclaimerStructV2 disclaimer{ get; set; }
		[ProtoMember(22)]
		public bool allow_upload_cover{ get; set; }
		[ProtoMember(23)]
		public bool is_commerce{ get; set; }
		[ProtoMember(24)]
		public CategoryCoverStructV2 category_cover_info{ get; set; }
		[ProtoMember(25)]
		public string hashtag_profile{ get; set; }
		[ProtoMember(26)]
		public string cover_photo{ get; set; }
		[ProtoMember(27)]
		public int is_hot_search{ get; set; }
		[ProtoMember(28)]
		public int link_type{ get; set; }
		[ProtoMember(29)]
		public AnnouncementStructV2 announcement_info{ get; set; }
		[ProtoMember(30)]
		public int content_type{ get; set; }
		[ProtoMember(31)]
		public int module_type{ get; set; }
		[ProtoMember(32)]
		public string profile_tag{ get; set; }
		[ProtoMember(33)]
		public List<string> cha_attrs{ get; set; }
		[ProtoMember(34)]
		public IconButtonStructV2 button{ get; set; }
	}
}