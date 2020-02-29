using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class XiguaTaskStructV2 {
		[ProtoMember(1)]
		public bool is_xigua_task{ get; set; }
		[ProtoMember(2)]
		public string jump_url{ get; set; }
		[ProtoMember(3)]
		public string title{ get; set; }
		[ProtoMember(4)]
		public string desc{ get; set; }
		[ProtoMember(5)]
		public string icon_url{ get; set; }
		[ProtoMember(6)]
		public int switch_type{ get; set; }
		[ProtoMember(7)]
		public string entrance_url{ get; set; }
	}
}