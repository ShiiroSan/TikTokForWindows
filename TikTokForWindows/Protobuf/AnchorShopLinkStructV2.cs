using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AnchorShopLinkStructV2 {
		[ProtoMember(1)]
		public string keyword{ get; set; }
		[ProtoMember(2)]
		public string url{ get; set; }
	}
}