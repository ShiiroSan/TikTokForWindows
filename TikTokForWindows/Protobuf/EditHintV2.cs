using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class EditHintV2 {
		[ProtoMember(1)]
		public string language{ get; set; }
		[ProtoMember(2)]
		public string hint{ get; set; }
	}
}