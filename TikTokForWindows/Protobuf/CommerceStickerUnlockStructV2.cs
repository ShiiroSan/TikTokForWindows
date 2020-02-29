using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class CommerceStickerUnlockStructV2 {
		[ProtoMember(1)]
		public string desc{ get; set; }
		[ProtoMember(2)]
		public string web_url{ get; set; }
		[ProtoMember(3)]
		public string open_url{ get; set; }
	}
}