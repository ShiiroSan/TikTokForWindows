using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class VPAInfoStructV2 {
		[ProtoMember(1)]
		public bool show_opt_out_button{ get; set; }
		[ProtoMember(2)]
		public int show_info_bar_type{ get; set; }
	}
}