using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class CommercePermissionStructV2 {
		[ProtoMember(1)]
		public int top_item{ get; set; }
		[ProtoMember(2)]
		public int ad_link{ get; set; }
		[ProtoMember(3)]
		public int star_atlas_order{ get; set; }
	}
}