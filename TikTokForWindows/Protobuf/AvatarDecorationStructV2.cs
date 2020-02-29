using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AvatarDecorationStructV2 {
		[ProtoMember(1)]
		public long id{ get; set; }
		[ProtoMember(2)]
		public string name{ get; set; }
		[ProtoMember(3)]
		public UrlStructV2 source_url{ get; set; }
	}
}