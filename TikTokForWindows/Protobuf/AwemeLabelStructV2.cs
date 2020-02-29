using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeLabelStructV2 {
		[ProtoMember(1)]
		public UrlStructV2 label_url{ get; set; }
		[ProtoMember(2)]
		public int label_type{ get; set; }
	}
}