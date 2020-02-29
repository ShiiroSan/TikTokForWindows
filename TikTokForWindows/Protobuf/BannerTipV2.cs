using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class BannerTipV2 {
		[ProtoMember(1)]
		public int banner_type{ get; set; }
		[ProtoMember(2)]
		public string banner_txt{ get; set; }
		[ProtoMember(3)]
		public int link_type{ get; set; }
		[ProtoMember(4)]
		public string link_url{ get; set; }
		[ProtoMember(5)]
		public string link_txt{ get; set; }
	}
}