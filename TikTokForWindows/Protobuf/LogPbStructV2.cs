using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class LogPbStructV2 {
		[ProtoMember(2)]
		public string impr_id{ get; set; }
	}
}