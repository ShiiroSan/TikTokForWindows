using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class FollowersDetailV2 {
		[ProtoMember(1)]
		public string name{ get; set; }
		[ProtoMember(2)]
		public string icon{ get; set; }
		[ProtoMember(3)]
		public int fans_count{ get; set; }
		[ProtoMember(4)]
		public string open_url{ get; set; }
		[ProtoMember(5)]
		public string apple_id{ get; set; }
		[ProtoMember(6)]
		public string download_url{ get; set; }
		[ProtoMember(7)]
		public string package_name{ get; set; }
		[ProtoMember(8)]
		public string app_name{ get; set; }
	}
}