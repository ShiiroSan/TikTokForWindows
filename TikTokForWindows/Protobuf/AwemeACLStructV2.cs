using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeACLStructV2 {
		[ProtoMember(1)]
		public ACLCommonStructV2 download_general{ get; set; }
		[ProtoMember(2)]
		public ACLCommonStructV2 download_mask_panel{ get; set; }
		[ProtoMember(3)]
		public ACLCommonStructV2 download_share_panel{ get; set; }
	}
}