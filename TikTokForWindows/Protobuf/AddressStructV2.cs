using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AddressStructV2 {
		[ProtoMember(1)]
		public string province{ get; set; }
		[ProtoMember(2)]
		public string city{ get; set; }
		[ProtoMember(3)]
		public string district{ get; set; }
		[ProtoMember(4)]
		public string address{ get; set; }
		[ProtoMember(5)]
		public string simple_addr{ get; set; }
		[ProtoMember(6)]
		public string city_code{ get; set; }
		[ProtoMember(7)]
		public string country{ get; set; }
		[ProtoMember(8)]
		public string country_code{ get; set; }
	}
}