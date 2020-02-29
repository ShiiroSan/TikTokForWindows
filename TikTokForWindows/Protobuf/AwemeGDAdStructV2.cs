using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeGDAdStructV2 {
		[ProtoMember(1)]
		public long ad_id{ get; set; }
		[ProtoMember(2)]
		public long cpt_seq{ get; set; }
		[ProtoMember(3)]
		public string req_id{ get; set; }
		[ProtoMember(4)]
		public long rit{ get; set; }
		[ProtoMember(5)]
		public int ad_price{ get; set; }
		[ProtoMember(6)]
		public long creative_id{ get; set; }
		[ProtoMember(7)]
		public string title{ get; set; }
		[ProtoMember(8)]
		public string source{ get; set; }
		[ProtoMember(9)]
		public string open_url{ get; set; }
		[ProtoMember(10)]
		public string web_url{ get; set; }
		[ProtoMember(11)]
		public string web_title{ get; set; }
		[ProtoMember(12)]
		public UrlStructV2 track_url_list{ get; set; }
		[ProtoMember(13)]
		public UrlStructV2 click_track_url_list{ get; set; }
		[ProtoMember(14)]
		public bool is_preview{ get; set; }
		[ProtoMember(15)]
		public UrlStructV2 play_track_url_list{ get; set; }
		[ProtoMember(16)]
		public UrlStructV2 playover_track_url_list{ get; set; }
		[ProtoMember(17)]
		public int effective_play_time{ get; set; }
		[ProtoMember(18)]
		public UrlStructV2 effective_play_track_url_list{ get; set; }
		[ProtoMember(19)]
		public long group_id{ get; set; }
		[ProtoMember(20)]
		public int video_transpose{ get; set; }
	}
}