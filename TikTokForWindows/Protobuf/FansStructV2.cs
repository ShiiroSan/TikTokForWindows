using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class FansStructV2 {
		[ProtoMember(1)]
		public string fans_name{ get; set; }
		[ProtoMember(2)]
		public int fans_level{ get; set; }
		[ProtoMember(3)]
		public bool is_fan{ get; set; }
		[ProtoMember(4)]
		public bool light_up{ get; set; }
	}
}