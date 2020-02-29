using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class aweme_v2_feed_request {
		[ProtoMember(1)]
		public int type{ get; set; }
		[ProtoMember(2)]
		public long max_cursor{ get; set; }
		[ProtoMember(3)]
		public long min_cursor{ get; set; }
		[ProtoMember(4)]
		public int count{ get; set; }
		[ProtoMember(5)]
		public int feed_style{ get; set; }
		[ProtoMember(6)]
		public long aweme_id{ get; set; }
		[ProtoMember(7)]
		public int pull_type{ get; set; }
		[ProtoMember(8)]
		public string volume{ get; set; }
		[ProtoMember(9)]
		public int need_relieve_aweme{ get; set; }
		[ProtoMember(10)]
		public int address_book_access{ get; set; }
		[ProtoMember(11)]
		public int gps_access{ get; set; }
		[ProtoMember(12)]
		public string top_view_cid{ get; set; }
		[ProtoMember(13)]
		public string content_language{ get; set; }
		[ProtoMember(14)]
		public string discard_cids{ get; set; }
		[ProtoMember(15)]
		public long interest_select_duration{ get; set; }
		[ProtoMember(16)]
		public string preload_aweme_ids{ get; set; }
		[ProtoMember(17)]
		public string download_sdk_info{ get; set; }
		[ProtoMember(18)]
		public int cached_item_num{ get; set; }
		[ProtoMember(19)]
		public int last_ad_show_interval{ get; set; }
	}
}