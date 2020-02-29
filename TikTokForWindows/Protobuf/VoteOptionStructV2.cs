using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class VoteOptionStructV2 {
		[ProtoMember(1)]
		public string option_text{ get; set; }
		[ProtoMember(2)]
		public long option_id{ get; set; }
		[ProtoMember(3)]
		public long vote_count{ get; set; }
		[ProtoMember(4)]
		public string option{ get; set; }
	}
}