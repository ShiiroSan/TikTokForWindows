using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeCommerceStructV2 {
		[ProtoMember(1)]
		public int ad_auth_status{ get; set; }
		[ProtoMember(2)]
		public int ad_source{ get; set; }
		[ProtoMember(3)]
		public bool avoid_global_pendant{ get; set; }
	}
}