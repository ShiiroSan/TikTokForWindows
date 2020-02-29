using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class ExtraStructV2 {
		[ProtoMember(1)]
		public long now{ get; set; }
		[ProtoMember(2)]
		public string logid{ get; set; }
		[ProtoMember(3)]
		public List<string> fatal_item_ids{ get; set; }
	}
}