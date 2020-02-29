using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AdCoverTitleV2 {
		[ProtoMember(1)]
		public string title{ get; set; }
		[ProtoMember(2)]
		public string web_url{ get; set; }
	}
}