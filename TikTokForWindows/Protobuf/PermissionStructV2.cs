using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class PermissionStructV2 {
		[ProtoMember(1)]
		public int follow_toast{ get; set; }
		[ProtoMember(2)]
		public int original_list{ get; set; }
		[ProtoMember(3)]
		public int shop_toast{ get; set; }
		[ProtoMember(4)]
		public int share_toast{ get; set; }
	}
}