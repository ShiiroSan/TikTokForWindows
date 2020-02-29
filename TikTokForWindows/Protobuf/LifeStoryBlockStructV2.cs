using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class LifeStoryBlockStructV2 {
		[ProtoMember(1)]
		public bool life_story_block{ get; set; }
		[ProtoMember(2)]
		public bool life_story_blocked{ get; set; }
	}
}