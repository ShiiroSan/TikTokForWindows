using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class VideoStructV2 {
		[ProtoMember(1)]
		public UrlStructV2 play_addr{ get; set; }
		[ProtoMember(2)]
		public UrlStructV2 cover{ get; set; }
		[ProtoMember(3)]
		public int height{ get; set; }
		[ProtoMember(4)]
		public int width{ get; set; }
		[ProtoMember(5)]
		public UrlStructV2 dynamic_cover{ get; set; }
		[ProtoMember(6)]
		public UrlStructV2 origin_cover{ get; set; }
		[ProtoMember(7)]
		public string ratio{ get; set; }
		[ProtoMember(8)]
		public UrlStructV2 download_addr{ get; set; }
		[ProtoMember(9)]
		public bool has_watermark{ get; set; }
		[ProtoMember(10)]
		public UrlStructV2 play_addr_lowbr{ get; set; }
		[ProtoMember(11)]
		public List<BitRateStructV2> bit_rate{ get; set; }
		[ProtoMember(12)]
		public UrlStructV2 new_download_addr{ get; set; }
		[ProtoMember(13)]
		public int duration{ get; set; }
		[ProtoMember(14)]
		public UrlStructV2 download_suffix_logo_addr{ get; set; }
		[ProtoMember(15)]
		public bool has_download_suffix_logo_addr{ get; set; }
		[ProtoMember(16)]
		public UrlStructV2 play_addr_265{ get; set; }
		[ProtoMember(17)]
		public int is_h265{ get; set; }
		[ProtoMember(18)]
		public UrlStructV2 play_addr_h264{ get; set; }
		[ProtoMember(19)]
		public UrlStructV2 ui_alike_download_addr{ get; set; }
		[ProtoMember(20)]
		public UrlStructV2 caption_download_addr{ get; set; }
		[ProtoMember(21)]
		public long cdn_url_expired{ get; set; }
		[ProtoMember(22)]
		public int is_long_video{ get; set; }
		[ProtoMember(23)]
		public string video_model{ get; set; }
		[ProtoMember(24)]
		public bool need_set_token{ get; set; }
	}
}