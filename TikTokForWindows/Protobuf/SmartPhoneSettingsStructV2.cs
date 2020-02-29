using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class SmartPhoneSettingsStructV2 {
		[ProtoMember(1)]
		public string phone_number{ get; set; }
		[ProtoMember(2)]
		public string phone_id{ get; set; }
		[ProtoMember(3)]
		public string encrypt_key{ get; set; }
	}
}