using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class VoteStructV2 {
		[ProtoMember(1)]
		public long vote_id{ get; set; }
		[ProtoMember(2)]
		public long ref_id{ get; set; }
		[ProtoMember(3)]
		public int ref_type{ get; set; }
		[ProtoMember(4)]
		public string question{ get; set; }
		[ProtoMember(5)]
		public List<VoteOptionStructV2> options{ get; set; }
		[ProtoMember(6)]
		public long select_option_id{ get; set; }
	}
}