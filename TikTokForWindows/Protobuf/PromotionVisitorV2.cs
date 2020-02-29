using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class PromotionVisitorV2 {
		[ProtoMember(1)]
		public List<UrlStructV2> avatar{ get; set; }
		[ProtoMember(2)]
		public long count{ get; set; }
	}
}