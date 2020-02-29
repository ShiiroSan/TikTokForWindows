using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class QuickShopSecondFloorV2 {
		[ProtoMember(1)]
		public string process_text{ get; set; }
		[ProtoMember(2)]
		public string enter_text{ get; set; }
		[ProtoMember(3)]
		public string trans_bg_text{ get; set; }
	}
}