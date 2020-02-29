using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class SimpleUserStructV2 {
		[ProtoMember(1)]
		public string uid{ get; set; }
		[ProtoMember(2)]
		public string nickname{ get; set; }
		[ProtoMember(3)]
		public string signature{ get; set; }
		[ProtoMember(4)]
		public UrlStructV2 avatar_thumb{ get; set; }
		[ProtoMember(5)]
		public int follow_status{ get; set; }
		[ProtoMember(6)]
		public int status{ get; set; }
		[ProtoMember(7)]
		public int user_rate{ get; set; }
		[ProtoMember(8)]
		public UrlStructV2 avatar_larger{ get; set; }
		[ProtoMember(9)]
		public HitTaskInfoV2 hit_task_info{ get; set; }
		[ProtoMember(10)]
		public string unique_id{ get; set; }
		[ProtoMember(11)]
		public string sec_uid{ get; set; }
	}
}