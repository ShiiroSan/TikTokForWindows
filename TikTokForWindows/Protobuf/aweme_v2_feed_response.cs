using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class aweme_v2_feed_response {
		[ProtoMember(1)]
		public int status_code{ get; set; }
		[ProtoMember(2)]
		public long min_cursor{ get; set; }
		[ProtoMember(3)]
		public long max_cursor{ get; set; }
		[ProtoMember(4)]
		public int has_more{ get; set; }
		[ProtoMember(5)]
		public List<AwemeStructV2> aweme_list{ get; set; }
		[ProtoMember(6)]
		public string rid{ get; set; }
		[ProtoMember(7)]
		public int home_model{ get; set; }
		[ProtoMember(8)]
		public int refresh_clear{ get; set; }
		[ProtoMember(9)]
		public ExtraStructV2 extra{ get; set; }
		[ProtoMember(10)]
		public LogPbStructV2 log_pb{ get; set; }
		[ProtoMember(11)]
		public string DebugInfo{ get; set; }
		[ProtoMember(12)]
		public GuideWordV2 guide_word{ get; set; }
		[ProtoMember(13)]
		public List<AwemeStructV2> preload_ads{ get; set; }
		[ProtoMember(14)]
		public string status_msg{ get; set; }
		[ProtoMember(15)]
		public int block_code{ get; set; }
		[ProtoMember(16)]
		public List<AwemeStructV2> preload_awemes{ get; set; }
	}
}