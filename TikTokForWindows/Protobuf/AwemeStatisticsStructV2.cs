using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeStatisticsStructV2 {
		[ProtoMember(1)]
		public string aweme_id{ get; set; }
		[ProtoMember(2)]
		public int comment_count{ get; set; }
		[ProtoMember(3)]
		public int digg_count{ get; set; }
		[ProtoMember(4)]
		public int download_count{ get; set; }
		[ProtoMember(5)]
		public int play_count{ get; set; }
		[ProtoMember(6)]
		public int share_count{ get; set; }
		[ProtoMember(7)]
		public int forward_count{ get; set; }
		[ProtoMember(8)]
		public int lose_count{ get; set; }
		[ProtoMember(9)]
		public int lose_comment_count{ get; set; }
	}
}