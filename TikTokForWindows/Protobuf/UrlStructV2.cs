using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class UrlStructV2 {
		[ProtoMember(1)]
		public string uri{ get; set; }
		[ProtoMember(2)]
		public List<string> url_list{ get; set; }
		[ProtoMember(3)]
		public int width{ get; set; }
		[ProtoMember(4)]
		public int height{ get; set; }
		[ProtoMember(5)]
		public string url_key{ get; set; }
		[ProtoMember(6)]
		public long data_size{ get; set; }
		[ProtoMember(7)]
		public string file_hash{ get; set; }
		[ProtoMember(8)]
		public string file_cs{ get; set; }
	}
}