using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeSearchStructV2 {
		[ProtoMember(1)]
		public string sentence{ get; set; }
		[ProtoMember(2)]
		public string challenge_id{ get; set; }
		[ProtoMember(3)]
		public string search_word{ get; set; }
		[ProtoMember(4)]
		public long value{ get; set; }
		[ProtoMember(5)]
		public int vb_rank{ get; set; }
		[ProtoMember(6)]
		public long vb_rank_value{ get; set; }
		[ProtoMember(7)]
		public int rank{ get; set; }
		[ProtoMember(8)]
		public string group_id{ get; set; }
		[ProtoMember(9)]
		public int label{ get; set; }
	}
}