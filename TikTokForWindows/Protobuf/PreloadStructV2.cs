using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class PreloadStructV2 {
		[ProtoMember(1)]
		public int comment{ get; set; }
		[ProtoMember(2)]
		public int profile{ get; set; }
		[ProtoMember(3)]
		public double comment_pro{ get; set; }
		[ProtoMember(4)]
		public double profile_pro{ get; set; }
		[ProtoMember(5)]
		public double comment_thres{ get; set; }
		[ProtoMember(6)]
		public double profile_thres{ get; set; }
		[ProtoMember(7)]
		public double comment_median_time{ get; set; }
		[ProtoMember(8)]
		public double profile_median_time{ get; set; }
		[ProtoMember(9)]
		public int model_v2{ get; set; }
	}
}