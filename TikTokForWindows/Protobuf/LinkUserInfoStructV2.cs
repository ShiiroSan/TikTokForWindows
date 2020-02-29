using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class LinkUserInfoStructV2 {
		[ProtoMember(1)]
		public int auth_status{ get; set; }
		[ProtoMember(2)]
		public int auth_type{ get; set; }
	}
}