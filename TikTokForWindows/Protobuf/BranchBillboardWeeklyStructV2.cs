using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class BranchBillboardWeeklyStructV2 {
		[ProtoMember(1)]
		public string uid{ get; set; }
		[ProtoMember(2)]
		public int edition_no{ get; set; }
		[ProtoMember(3)]
		public long start_time{ get; set; }
		[ProtoMember(4)]
		public long end_time{ get; set; }
	}
}