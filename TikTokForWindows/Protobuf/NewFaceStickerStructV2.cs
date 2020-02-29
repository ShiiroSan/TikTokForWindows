using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class NewFaceStickerStructV2 {
		[ProtoMember(1)]
		public string id{ get; set; }
		[ProtoMember(2)]
		public string name{ get; set; }
		[ProtoMember(3)]
		public List<string> children{ get; set; }
		[ProtoMember(4)]
		public UrlStructV2 icon_url{ get; set; }
		[ProtoMember(5)]
		public string owner_id{ get; set; }
		[ProtoMember(6)]
		public string owner_nickname{ get; set; }
		[ProtoMember(7)]
		public int user_count{ get; set; }
		[ProtoMember(8)]
		public string desc{ get; set; }
		[ProtoMember(9)]
		public string effect_id{ get; set; }
		[ProtoMember(10)]
		public ShareStructV2 share_info{ get; set; }
		[ProtoMember(11)]
		public bool is_favorite{ get; set; }
		[ProtoMember(12)]
		public CommerceStickerStructV2 commerce_sticker{ get; set; }
		[ProtoMember(13)]
		public List<string> tags{ get; set; }
		[ProtoMember(14)]
		public UrlStructV2 avatar_thumb{ get; set; }
		[ProtoMember(15)]
		public UrlStructV2 avatar_medium{ get; set; }
		[ProtoMember(16)]
		public UrlStructV2 avatar_large{ get; set; }
		[ProtoMember(17)]
		public long vv_count{ get; set; }
		[ProtoMember(18)]
		public string extra{ get; set; }
	}
}