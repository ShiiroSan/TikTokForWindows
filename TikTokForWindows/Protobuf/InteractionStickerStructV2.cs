using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class InteractionStickerStructV2 {
		[ProtoMember(1)]
		public int type{ get; set; }
		[ProtoMember(2)]
		public int index{ get; set; }
		[ProtoMember(3)]
		public PoiStructV2 poi_info{ get; set; }
		[ProtoMember(4)]
		public string track_info{ get; set; }
		[ProtoMember(5)]
		public string attr{ get; set; }
		[ProtoMember(6)]
		public VoteStructV2 vote_info{ get; set; }
	}
}