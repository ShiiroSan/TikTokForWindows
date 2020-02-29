using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class RFansGroupInfoV2 {
		[ProtoMember(1)]
		public string schema{ get; set; }
		[ProtoMember(2)]
		public string token{ get; set; }
		[ProtoMember(3)]
		public string download_url{ get; set; }
	}
}