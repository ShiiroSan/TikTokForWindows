using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class HotListStructV2 {
		[ProtoMember(1)]
		public string title{ get; set; }
		[ProtoMember(2)]
		public string image_url{ get; set; }
		[ProtoMember(3)]
		public string schema{ get; set; }
		[ProtoMember(4)]
		public int type{ get; set; }
		[ProtoMember(5)]
		public string i18n_title{ get; set; }
	}
}