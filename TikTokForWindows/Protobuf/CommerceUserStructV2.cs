using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class CommerceUserStructV2 {
		[ProtoMember(1)]
		public int star_atlas{ get; set; }
		[ProtoMember(2)]
		public bool show_star_atlas_cooperation{ get; set; }
		[ProtoMember(3)]
		public bool has_ads_entry{ get; set; }
		[ProtoMember(4)]
		public LinkUserInfoStructV2 link_user_info{ get; set; }
		[ProtoMember(5)]
		public int ad_influencer_type{ get; set; }
	}
}