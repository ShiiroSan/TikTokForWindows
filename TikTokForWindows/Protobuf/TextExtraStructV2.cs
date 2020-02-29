using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class TextExtraStructV2 {
		[ProtoMember(1)]
		public int start{ get; set; }
		[ProtoMember(2)]
		public int end{ get; set; }
		[ProtoMember(3)]
		public string user_id{ get; set; }
		[ProtoMember(4)]
		public int type{ get; set; }
		[ProtoMember(5)]
		public string hashtag_name{ get; set; }
		[ProtoMember(6)]
		public string hashtag_id{ get; set; }
		[ProtoMember(7)]
		public bool is_commerce{ get; set; }
		[ProtoMember(8)]
		public string hashTagName{ get; set; }
		[ProtoMember(9)]
		public string sec_uid{ get; set; }
		[ProtoMember(10)]
		public string aweme_id{ get; set; }
	}
}