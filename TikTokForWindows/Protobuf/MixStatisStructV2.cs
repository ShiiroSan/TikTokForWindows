using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class MixStatisStructV2 {
		[ProtoMember(1)]
		public long play_vv{ get; set; }
		[ProtoMember(2)]
		public long collect_vv{ get; set; }
		[ProtoMember(3)]
		public long current_episode{ get; set; }
		[ProtoMember(4)]
		public long updated_to_episode{ get; set; }
		[ProtoMember(5)]
		public long has_updated_episode{ get; set; }
	}
}