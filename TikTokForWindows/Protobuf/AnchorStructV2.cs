using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AnchorStructV2 {
		[ProtoMember(1)]
		public int show_type{ get; set; }
		[ProtoMember(2)]
		public int business_type{ get; set; }
		[ProtoMember(3)]
		public AnchorWikipediaStructV2 wikipedia_info{ get; set; }
		[ProtoMember(4)]
		public AnchorShopLinkStructV2 shop_link{ get; set; }
		[ProtoMember(5)]
		public AnchorCommonStructV2 anchor_info{ get; set; }
		[ProtoMember(6)]
		public string anchor_id{ get; set; }
	}
}