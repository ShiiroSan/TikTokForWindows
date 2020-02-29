using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class OpenPlatformStructV2 {
		[ProtoMember(1)]
		public string name{ get; set; }
		[ProtoMember(2)]
		public string icon{ get; set; }
		[ProtoMember(3)]
		public string link{ get; set; }
		[ProtoMember(4)]
		public string raw_data{ get; set; }
	}
}