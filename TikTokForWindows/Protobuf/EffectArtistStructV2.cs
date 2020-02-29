using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class EffectArtistStructV2 {
		[ProtoMember(1)]
		public int total{ get; set; }
	}
}