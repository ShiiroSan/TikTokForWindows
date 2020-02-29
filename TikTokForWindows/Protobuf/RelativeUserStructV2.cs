using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class RelativeUserStructV2 {
		[ProtoMember(1)]
		public long uid{ get; set; }
		[ProtoMember(2)]
		public UrlStructV2 avatar{ get; set; }
		[ProtoMember(3)]
		public string nickname{ get; set; }
		[ProtoMember(4)]
		public string remark_name{ get; set; }
		[ProtoMember(5)]
		public UrlStructV2 avatar_larger{ get; set; }
		[ProtoMember(6)]
		public UrlStructV2 avatar_thumb{ get; set; }
		[ProtoMember(7)]
		public int follow_status{ get; set; }
		[ProtoMember(8)]
		public string sec_uid{ get; set; }
	}
}