using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class HotsearchSprintStructV2 {
		[ProtoMember(1)]
		public int sprint{ get; set; }
		[ProtoMember(2)]
		public List<SimpleUserStructV2> followers{ get; set; }
	}
}