using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class MicroAppStructV2 {
		[ProtoMember(1)]
		public string app_id{ get; set; }
		[ProtoMember(2)]
		public string app_name{ get; set; }
		[ProtoMember(3)]
		public string icon{ get; set; }
		[ProtoMember(4)]
		public int orientation{ get; set; }
		[ProtoMember(5)]
		public string schema{ get; set; }
		[ProtoMember(6)]
		public int state{ get; set; }
		[ProtoMember(7)]
		public string summary{ get; set; }
		[ProtoMember(8)]
		public int type{ get; set; }
		[ProtoMember(9)]
		public string description{ get; set; }
		[ProtoMember(10)]
		public string title{ get; set; }
		[ProtoMember(11)]
		public MicroAppCardStructV2 card{ get; set; }
		[ProtoMember(12)]
		public string web_url{ get; set; }
	}
}