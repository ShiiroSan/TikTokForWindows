using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeControlStructV2 {
		[ProtoMember(1)]
		public bool can_forward{ get; set; }
		[ProtoMember(2)]
		public bool can_share{ get; set; }
		[ProtoMember(3)]
		public bool can_comment{ get; set; }
		[ProtoMember(4)]
		public bool can_show_comment{ get; set; }
	}
}