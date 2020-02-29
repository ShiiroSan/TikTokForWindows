using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class RecommendItemStructV2 {
		[ProtoMember(1)]
		public string aweme_id{ get; set; }
		[ProtoMember(2)]
		public UrlStructV2 cover{ get; set; }
		[ProtoMember(3)]
		public UrlStructV2 dynamic_cover{ get; set; }
		[ProtoMember(4)]
		public long media_type{ get; set; }
	}
}