using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeCommerceStickerStructV2 {
		[ProtoMember(1)]
		public long commerce_sticker_id{ get; set; }
		[ProtoMember(2)]
		public UrlStructV2 icon_url{ get; set; }
		[ProtoMember(3)]
		public string letters{ get; set; }
		[ProtoMember(4)]
		public string open_url{ get; set; }
		[ProtoMember(5)]
		public string web_url{ get; set; }
		[ProtoMember(6)]
		public string web_url_title{ get; set; }
	}
}