using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class CommerceActivityStructV2 {
		[ProtoMember(1)]
		public int act_type{ get; set; }
		[ProtoMember(2)]
		public UrlStructV2 image{ get; set; }
		[ProtoMember(3)]
		public string jump_web_url{ get; set; }
		[ProtoMember(4)]
		public string jump_open_url{ get; set; }
		[ProtoMember(5)]
		public string title{ get; set; }
		[ProtoMember(6)]
		public long start_time{ get; set; }
		[ProtoMember(7)]
		public long end_time{ get; set; }
		[ProtoMember(8)]
		public List<ActivityTimeRangeV2> time_range{ get; set; }
		[ProtoMember(9)]
		public UrlStructV2 track_url_list{ get; set; }
		[ProtoMember(10)]
		public UrlStructV2 click_track_url_list{ get; set; }
	}
}