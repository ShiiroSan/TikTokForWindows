using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class ImageInfoStructV2 {
		[ProtoMember(1)]
		public int height{ get; set; }
		[ProtoMember(2)]
		public int width{ get; set; }
		[ProtoMember(3)]
		public UrlStructV2 label_large{ get; set; }
		[ProtoMember(4)]
		public UrlStructV2 label_thumb{ get; set; }
	}
}