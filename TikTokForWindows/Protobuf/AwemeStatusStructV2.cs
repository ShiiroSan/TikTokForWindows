using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemeStatusStructV2 {
		[ProtoMember(1)]
		public string aweme_id{ get; set; }
		[ProtoMember(2)]
		public bool is_delete{ get; set; }
		[ProtoMember(3)]
		public bool allow_share{ get; set; }
		[ProtoMember(4)]
		public bool allow_comment{ get; set; }
		[ProtoMember(5)]
		public bool is_private{ get; set; }
		[ProtoMember(6)]
		public bool with_goods{ get; set; }
		[ProtoMember(7)]
		public int private_status{ get; set; }
		[ProtoMember(8)]
		public bool with_fusion_goods{ get; set; }
		[ProtoMember(9)]
		public bool in_reviewing{ get; set; }
		[ProtoMember(10)]
		public int reviewed{ get; set; }
		[ProtoMember(11)]
		public bool self_see{ get; set; }
		[ProtoMember(12)]
		public bool is_prohibited{ get; set; }
		[ProtoMember(13)]
		public int download_status{ get; set; }
	}
}