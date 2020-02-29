using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class NationalTaskLinkStructV2 {
		[ProtoMember(1)]
		public string id{ get; set; }
		[ProtoMember(2)]
		public string title{ get; set; }
		[ProtoMember(3)]
		public string sub_title{ get; set; }
		[ProtoMember(4)]
		public UrlStructV2 avatar_icon{ get; set; }
		[ProtoMember(5)]
		public string web_url{ get; set; }
		[ProtoMember(6)]
		public string open_url{ get; set; }
	}
}