using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AnnouncementStructV2 {
		[ProtoMember(1)]
		public string title{ get; set; }
		[ProtoMember(2)]
		public string body{ get; set; }
	}
}