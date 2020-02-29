using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class WebcastRoomStructV2 {
		[ProtoMember(1)]
		public long room_id{ get; set; }
		[ProtoMember(2)]
		public int status{ get; set; }
		[ProtoMember(3)]
		public UserStructV2 owner{ get; set; }
		[ProtoMember(4)]
		public string title{ get; set; }
		[ProtoMember(5)]
		public int user_count{ get; set; }
		[ProtoMember(6)]
		public long create_time{ get; set; }
		[ProtoMember(7)]
		public long finish_time{ get; set; }
		[ProtoMember(8)]
		public long stream_id{ get; set; }
		[ProtoMember(9)]
		public StreamUrlStructV2 stream_url{ get; set; }
		[ProtoMember(10)]
		public ShareStructV2 share_info{ get; set; }
		[ProtoMember(11)]
		public int digg_count{ get; set; }
		[ProtoMember(12)]
		public int total_user_count{ get; set; }
		[ProtoMember(13)]
		public int coins{ get; set; }
		[ProtoMember(14)]
		public bool in_sandbox{ get; set; }
		[ProtoMember(15)]
		public UrlStructV2 dynamic_cover{ get; set; }
		[ProtoMember(16)]
		public UrlStructV2 room_cover{ get; set; }
		[ProtoMember(17)]
		public string room_type_tag{ get; set; }
		[ProtoMember(18)]
		public StreamUrlStructV2 additional_stream_url{ get; set; }
		[ProtoMember(19)]
		public UrlStructV2 webp_cover{ get; set; }
		[ProtoMember(20)]
		public string extra{ get; set; }
		[ProtoMember(21)]
		public bool live_type_audio{ get; set; }
		[ProtoMember(22)]
		public bool live_type_third_party{ get; set; }
		[ProtoMember(23)]
		public bool live_type_screenshot{ get; set; }
		[ProtoMember(24)]
		public bool live_type_official{ get; set; }
		[ProtoMember(25)]
		public bool live_type_normal{ get; set; }
		[ProtoMember(26)]
		public bool live_type_linkmic{ get; set; }
		[ProtoMember(27)]
		public bool live_type_sandbox{ get; set; }
	}
}