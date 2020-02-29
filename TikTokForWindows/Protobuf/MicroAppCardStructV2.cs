using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class MicroAppCardStructV2 {
		[ProtoMember(1)]
		public string image_url{ get; set; }
		[ProtoMember(2)]
		public string text{ get; set; }
		[ProtoMember(3)]
		public int wait_time{ get; set; }
	}
}