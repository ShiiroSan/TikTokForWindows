using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class MixStructV2 {
		[ProtoMember(1)]
		public string mix_id{ get; set; }
		[ProtoMember(2)]
		public string mix_name{ get; set; }
		[ProtoMember(3)]
		public UrlStructV2 cover_url{ get; set; }
		[ProtoMember(4)]
		public UrlStructV2 icon_url{ get; set; }
		[ProtoMember(5)]
		public MixStatusStructV2 status{ get; set; }
		[ProtoMember(6)]
		public MixStatisStructV2 statis{ get; set; }
		[ProtoMember(7)]
		public string desc{ get; set; }
		[ProtoMember(8)]
		public UserStructV2 author{ get; set; }
		[ProtoMember(9)]
		public string extra{ get; set; }
		[ProtoMember(10)]
		public ShareStructV2 share_info{ get; set; }
	}
}