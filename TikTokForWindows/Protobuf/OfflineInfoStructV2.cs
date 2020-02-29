using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class OfflineInfoStructV2 {
		[ProtoMember(1)]
		public int offline_info_type{ get; set; }
		[ProtoMember(2)]
		public string text{ get; set; }
		[ProtoMember(3)]
		public string action{ get; set; }
	}
}