using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class LiveHonorStructV2 {
		[ProtoMember(1)]
		public int honor_level{ get; set; }
		[ProtoMember(2)]
		public long honor_score{ get; set; }
		[ProtoMember(3)]
		public UrlStructV2 badge_thumb{ get; set; }
	}
}