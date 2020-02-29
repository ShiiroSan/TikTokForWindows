using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class HitTaskInfoV2 {
		[ProtoMember(1)]
		public int compeleted_task_cnt{ get; set; }
		[ProtoMember(2)]
		public int total_task_cnt{ get; set; }
	}
}