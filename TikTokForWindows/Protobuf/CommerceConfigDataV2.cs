using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class CommerceConfigDataV2 {
		[ProtoMember(1)]
		public int type{ get; set; }
		[ProtoMember(2)]
		public int priority{ get; set; }
		[ProtoMember(3)]
		public ItemLikeEggDataV2 item_like_egg{ get; set; }
		[ProtoMember(4)]
		public StickerPendantStructV2 sticker_pendant{ get; set; }
		[ProtoMember(5)]
		public string data{ get; set; }
	}
}