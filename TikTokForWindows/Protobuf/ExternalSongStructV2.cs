using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class ExternalSongStructV2 {
		[ProtoMember(1)]
		public string h5_url{ get; set; }
		[ProtoMember(2)]
		public string partner_name{ get; set; }
		[ProtoMember(3)]
		public string partner_song_id{ get; set; }
		[ProtoMember(4)]
		public string external_song_key{ get; set; }
	}
}