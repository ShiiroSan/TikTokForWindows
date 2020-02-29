using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class DescendantStructV2 {
		[ProtoMember(1)]
		public List<string> platforms{ get; set; }
		[ProtoMember(2)]
		public string notify_msg{ get; set; }
	}
}