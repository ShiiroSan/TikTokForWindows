using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class WebcastRoomFeedCellStructV2 {
		[ProtoMember(1)]
		public WebcastRoomStructV2 room{ get; set; }
		[ProtoMember(2)]
		public int type{ get; set; }
		[ProtoMember(3)]
		public FansStructV2 fans_struct{ get; set; }
		[ProtoMember(4)]
		public string tag{ get; set; }
		[ProtoMember(5)]
		public long tag_id{ get; set; }
		[ProtoMember(6)]
		public UrlStructV2 icon{ get; set; }
		[ProtoMember(7)]
		public string distance{ get; set; }
	}
}