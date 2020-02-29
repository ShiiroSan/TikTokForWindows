using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeNationalTaskStructV2 {
		[ProtoMember(1)]
		public NationalTaskLinkStructV2 link_info{ get; set; }
	}
}