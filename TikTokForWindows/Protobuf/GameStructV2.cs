using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class GameStructV2 {
		[ProtoMember(1)]
		public int game_type{ get; set; }
		[ProtoMember(2)]
		public int game_score{ get; set; }
	}
}