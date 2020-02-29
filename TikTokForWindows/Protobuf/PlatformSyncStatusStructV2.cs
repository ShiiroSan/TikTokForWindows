using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class PlatformSyncStatusStructV2 {
		[ProtoMember(1)]
		public string platform_name{ get; set; }
		[ProtoMember(2)]
		public string nickname{ get; set; }
		[ProtoMember(3)]
		public bool full_synced{ get; set; }
	}
}