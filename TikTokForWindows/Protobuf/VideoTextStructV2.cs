using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class VideoTextStructV2 {
		[ProtoMember(1)]
		public string text{ get; set; }
		[ProtoMember(2)]
		public string color{ get; set; }
		[ProtoMember(3)]
		public string color_text{ get; set; }
		[ProtoMember(4)]
		public int type{ get; set; }
	}
}