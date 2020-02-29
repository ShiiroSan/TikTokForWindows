using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class PositionStructV2 {
		[ProtoMember(1)]
		public int begin{ get; set; }
		[ProtoMember(2)]
		public int end{ get; set; }
	}
}