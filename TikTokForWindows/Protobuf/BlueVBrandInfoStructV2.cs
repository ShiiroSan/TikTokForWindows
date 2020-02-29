using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class BlueVBrandInfoStructV2 {
		[ProtoMember(1)]
		public int category_id{ get; set; }
		[ProtoMember(2)]
		public string category_name{ get; set; }
		[ProtoMember(3)]
		public int brand_id{ get; set; }
		[ProtoMember(4)]
		public string brand_name{ get; set; }
		[ProtoMember(5)]
		public UrlStructV2 logo_url{ get; set; }
		[ProtoMember(6)]
		public int heat{ get; set; }
		[ProtoMember(7)]
		public int rank{ get; set; }
		[ProtoMember(8)]
		public int rank_diff{ get; set; }
		[ProtoMember(9)]
		public string tag_name{ get; set; }
	}
}