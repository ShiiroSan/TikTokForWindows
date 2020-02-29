using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class ACLCommonStructV2 {
		[ProtoMember(1)]
		public int code{ get; set; }
		[ProtoMember(2)]
		public int show_type{ get; set; }
		[ProtoMember(3)]
		public string toast_msg{ get; set; }
		[ProtoMember(4)]
		public string extra{ get; set; }
	}
}