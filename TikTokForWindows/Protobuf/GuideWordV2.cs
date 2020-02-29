using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class GuideWordV2 {
		[ProtoMember(1)]
		public string word{ get; set; }
		[ProtoMember(2)]
		public string search_word{ get; set; }
		[ProtoMember(3)]
		public int type{ get; set; }
		[ProtoMember(4)]
		public int breathe_times{ get; set; }
	}
}