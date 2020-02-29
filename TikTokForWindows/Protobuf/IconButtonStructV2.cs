using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class IconButtonStructV2 {
		[ProtoMember(1)]
		public string text{ get; set; }
		[ProtoMember(2)]
		public UrlStructV2 icon{ get; set; }
		[ProtoMember(3)]
		public string action{ get; set; }
	}
}