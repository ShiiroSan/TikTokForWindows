using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class ItemCommentEggMaterialDataV2 {
		[ProtoMember(1)]
		public string file_type{ get; set; }
		[ProtoMember(2)]
		public string material_url{ get; set; }
		[ProtoMember(3)]
		public string open_url{ get; set; }
		[ProtoMember(4)]
		public string web_url{ get; set; }
		[ProtoMember(5)]
		public string regex{ get; set; }
		[ProtoMember(6)]
		public string egg_id{ get; set; }
	}
}