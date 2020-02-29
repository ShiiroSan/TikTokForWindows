using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class RedPacketStructV2 {
		[ProtoMember(1)]
		public int type{ get; set; }
		[ProtoMember(2)]
		public long till_seckill_time{ get; set; }
		[ProtoMember(3)]
		public long seckill_time{ get; set; }
		[ProtoMember(4)]
		public string star_name{ get; set; }
		[ProtoMember(5)]
		public string words{ get; set; }
		[ProtoMember(6)]
		public string timestamp_info{ get; set; }
		[ProtoMember(7)]
		public UrlStructV2 voice{ get; set; }
		[ProtoMember(8)]
		public UrlStructV2 default_voice{ get; set; }
		[ProtoMember(9)]
		public int voice_start{ get; set; }
		[ProtoMember(10)]
		public int voice_end{ get; set; }
		[ProtoMember(11)]
		public UrlStructV2 tag_icon{ get; set; }
	}
}