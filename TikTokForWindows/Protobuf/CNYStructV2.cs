using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class CNYStructV2 {
		[ProtoMember(1)]
		public long start_time{ get; set; }
		[ProtoMember(2)]
		public long end_time{ get; set; }
		[ProtoMember(3)]
		public bool topview_valid{ get; set; }
		[ProtoMember(4)]
		public int feed_show_time{ get; set; }
		[ProtoMember(5)]
		public string live_info{ get; set; }
	}
}