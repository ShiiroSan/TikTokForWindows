using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class PoiFrontendTypeStructV2 {
		[ProtoMember(1)]
		public string code{ get; set; }
		[ProtoMember(2)]
		public string name{ get; set; }
		[ProtoMember(3)]
		public string desc{ get; set; }
	}
}