using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AnchorWikipediaStructV2 {
		[ProtoMember(1)]
		public string keyword{ get; set; }
		[ProtoMember(2)]
		public string lang{ get; set; }
		[ProtoMember(3)]
		public string url{ get; set; }
	}
}