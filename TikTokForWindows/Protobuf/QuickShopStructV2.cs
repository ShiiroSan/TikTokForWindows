using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class QuickShopStructV2 {
		[ProtoMember(1)]
		public string quick_shop_url{ get; set; }
		[ProtoMember(2)]
		public string quick_shop_name{ get; set; }
		[ProtoMember(3)]
		public bool with_text_entry{ get; set; }
		[ProtoMember(4)]
		public QuickShopSecondFloorV2 second_floor_info{ get; set; }
	}
}