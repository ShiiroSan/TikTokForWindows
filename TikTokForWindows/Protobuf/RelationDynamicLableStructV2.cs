using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class RelationDynamicLableStructV2 {
		[ProtoMember(1)]
		public string nickname{ get; set; }
		[ProtoMember(2)]
		public string label_info{ get; set; }
		[ProtoMember(3)]
		public int count{ get; set; }
		[ProtoMember(4)]
		public string user_id{ get; set; }
		[ProtoMember(5)]
		public int type{ get; set; }
	}
}