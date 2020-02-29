using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeStarAtlasStructV2 {
		[ProtoMember(1)]
		public int review_status{ get; set; }
		[ProtoMember(2)]
		public StarAtlasLinkStructV2 link_info{ get; set; }
	}
}