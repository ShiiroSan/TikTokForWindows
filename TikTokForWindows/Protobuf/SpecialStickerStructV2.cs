using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class SpecialStickerStructV2 {
		[ProtoMember(1)]
		public int sticker_type{ get; set; }
		[ProtoMember(2)]
		public string link{ get; set; }
		[ProtoMember(3)]
		public string title{ get; set; }
		[ProtoMember(4)]
		public string sticker_id{ get; set; }
		[ProtoMember(5)]
		public UrlStructV2 icon_url{ get; set; }
		[ProtoMember(6)]
		public string open_url{ get; set; }
	}
}