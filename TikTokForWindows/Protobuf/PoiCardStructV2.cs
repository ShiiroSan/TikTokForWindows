using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class PoiCardStructV2 {
		[ProtoMember(1)]
		public int is_show{ get; set; }
		[ProtoMember(2)]
		public string url{ get; set; }
	}
}