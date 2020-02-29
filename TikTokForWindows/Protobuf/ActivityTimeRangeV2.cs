using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class ActivityTimeRangeV2 {
		[ProtoMember(1)]
		public double start{ get; set; }
		[ProtoMember(2)]
		public double end{ get; set; }
		[ProtoMember(3)]
		public double duration{ get; set; }
	}
}