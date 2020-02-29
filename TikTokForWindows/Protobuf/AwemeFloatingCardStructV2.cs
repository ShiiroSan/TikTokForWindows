using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeFloatingCardStructV2 {
		[ProtoMember(1)]
		public string schema{ get; set; }
		[ProtoMember(2)]
		public string schema_desc{ get; set; }
		[ProtoMember(3)]
		public List<UrlStructV2> icons{ get; set; }
		[ProtoMember(4)]
		public string title{ get; set; }
		[ProtoMember(5)]
		public string description{ get; set; }
		[ProtoMember(6)]
		public string button_desc{ get; set; }
		[ProtoMember(7)]
		public UrlStructV2 button_bg{ get; set; }
	}
}