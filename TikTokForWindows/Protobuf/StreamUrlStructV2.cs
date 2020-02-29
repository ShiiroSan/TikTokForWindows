using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class StreamUrlStructV2 {
		[ProtoMember(1)]
		public long sid{ get; set; }
		[ProtoMember(2)]
		public string rtmp_pull_url{ get; set; }
		[ProtoMember(3)]
		public string rtmp_push_url{ get; set; }
		[ProtoMember(4)]
		public int provider{ get; set; }
		[ProtoMember(5)]
		public string extra{ get; set; }
		[ProtoMember(6)]
		public string id{ get; set; }
	}
}