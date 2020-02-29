using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class CommerceStickerStructV2 {
		[ProtoMember(1)]
		public string id{ get; set; }
		[ProtoMember(2)]
		public string ad_owner_id{ get; set; }
		[ProtoMember(3)]
		public string ad_owner_name{ get; set; }
		[ProtoMember(4)]
		public string detail_desc{ get; set; }
		[ProtoMember(5)]
		public string detail_letters{ get; set; }
		[ProtoMember(6)]
		public string detail_open_url{ get; set; }
		[ProtoMember(7)]
		public string detail_web_url{ get; set; }
		[ProtoMember(8)]
		public string detail_web_url_title{ get; set; }
		[ProtoMember(9)]
		public string screen_desc{ get; set; }
		[ProtoMember(10)]
		public bool screen_switch{ get; set; }
		[ProtoMember(11)]
		public UrlStructV2 publish_icon_url{ get; set; }
		[ProtoMember(12)]
		public string publish_letters{ get; set; }
		[ProtoMember(13)]
		public string publish_open_url{ get; set; }
		[ProtoMember(14)]
		public string publish_web_url{ get; set; }
		[ProtoMember(15)]
		public string publish_web_url_title{ get; set; }
		[ProtoMember(16)]
		public string music_id{ get; set; }
		[ProtoMember(17)]
		public string challenge_id{ get; set; }
		[ProtoMember(18)]
		public UrlStructV2 screen_icon{ get; set; }
		[ProtoMember(19)]
		public long expire_time{ get; set; }
		[ProtoMember(20)]
		public CommerceStickerUnlockStructV2 unlock_info{ get; set; }
	}
}