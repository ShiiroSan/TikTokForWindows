using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeAnchorStructV2 {
		[ProtoMember(1)]
		public int type{ get; set; }
		[ProtoMember(2)]
		public string id{ get; set; }
		[ProtoMember(3)]
		public UrlStructV2 icon{ get; set; }
		[ProtoMember(4)]
		public string title{ get; set; }
		[ProtoMember(5)]
		public string open_url{ get; set; }
		[ProtoMember(6)]
		public string web_url{ get; set; }
		[ProtoMember(7)]
		public string mp_url{ get; set; }
		[ProtoMember(99)]
		public string extra{ get; set; }
	}
}