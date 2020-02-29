using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeRiskStructV2 {
		[ProtoMember(1)]
		public bool vote{ get; set; }
		[ProtoMember(2)]
		public bool warn{ get; set; }
		[ProtoMember(3)]
		public bool risk_sink{ get; set; }
		[ProtoMember(4)]
		public int type{ get; set; }
		[ProtoMember(5)]
		public string content{ get; set; }
	}
}