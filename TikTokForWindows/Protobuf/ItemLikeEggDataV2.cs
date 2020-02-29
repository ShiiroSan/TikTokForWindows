using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class ItemLikeEggDataV2 {
		[ProtoMember(1)]
		public string material_url{ get; set; }
		[ProtoMember(2)]
		public string file_type{ get; set; }
	}
}