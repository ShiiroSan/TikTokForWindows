using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class VideoControlV2 {
		[ProtoMember(1)]
		public bool allow_download{ get; set; }
		[ProtoMember(2)]
		public int share_type{ get; set; }
		[ProtoMember(3)]
		public int show_progress_bar{ get; set; }
		[ProtoMember(4)]
		public int draft_progress_bar{ get; set; }
		[ProtoMember(5)]
		public bool allow_duet{ get; set; }
		[ProtoMember(6)]
		public bool allow_react{ get; set; }
		[ProtoMember(7)]
		public int prevent_download_type{ get; set; }
		[ProtoMember(8)]
		public bool allow_dynamic_wallpaper{ get; set; }
		[ProtoMember(9)]
		public int timer_status{ get; set; }
	}
}