using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class RelationLabelStructV2 {
		[ProtoMember(1)]
		public List<RelativeUserStructV2> user_list{ get; set; }
		[ProtoMember(2)]
		public int type{ get; set; }
		[ProtoMember(3)]
		public string extra{ get; set; }
	}
}