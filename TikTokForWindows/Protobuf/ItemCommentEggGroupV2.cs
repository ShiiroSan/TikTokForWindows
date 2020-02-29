using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class ItemCommentEggGroupV2 {
		[ProtoMember(1)]
		public List<EditHintV2> edit_hint_list{ get; set; }
		[ProtoMember(2)]
		public List<ItemCommentEggMaterialDataV2> item_comment_eggs{ get; set; }
	}
}