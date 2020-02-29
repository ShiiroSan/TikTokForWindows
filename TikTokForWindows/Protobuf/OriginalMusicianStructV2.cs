using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class OriginalMusicianStructV2 {
		[ProtoMember(1)]
		public int music_count{ get; set; }
		[ProtoMember(2)]
		public int music_used_count{ get; set; }
		[ProtoMember(3)]
		public UrlStructV2 music_qrcode_url{ get; set; }
		[ProtoMember(4)]
		public UrlStructV2 music_cover_url{ get; set; }
		[ProtoMember(5)]
		public int digg_count{ get; set; }
	}
}