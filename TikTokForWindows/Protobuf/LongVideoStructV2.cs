using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class LongVideoStructV2 {
		[ProtoMember(1)]
		public VideoStructV2 video{ get; set; }
		[ProtoMember(2)]
		public int long_video_type{ get; set; }
		[ProtoMember(3)]
		public double trailer_start_time{ get; set; }
		[ProtoMember(4)]
		public VideoControlV2 video_control{ get; set; }
	}
}