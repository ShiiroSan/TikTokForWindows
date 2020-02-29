using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class DouplusToastStructV2 {
		[ProtoMember(1)]
		public int id{ get; set; }
		[ProtoMember(2)]
		public string toast{ get; set; }
	}
}