using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class MixStatusStructV2 {
		[ProtoMember(1)]
		public int status{ get; set; }
		[ProtoMember(2)]
		public int is_collected{ get; set; }
	}
}