using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class BitRateStructV2 {
		[ProtoMember(1)]
		public string gear_name{ get; set; }
		[ProtoMember(2)]
		public int quality_type{ get; set; }
		[ProtoMember(3)]
		public int bit_rate{ get; set; }
		[ProtoMember(4)]
		public UrlStructV2 play_addr{ get; set; }
		[ProtoMember(5)]
		public int is_h265{ get; set; }
		[ProtoMember(6)]
		public UrlStructV2 play_addr_265{ get; set; }
	}
}