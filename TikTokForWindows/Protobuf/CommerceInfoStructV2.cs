using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class CommerceInfoStructV2 {
		[ProtoMember(1)]
		public UrlStructV2 head_image_url{ get; set; }
		[ProtoMember(2)]
		public List<OfflineInfoStructV2> offline_info_list{ get; set; }
		[ProtoMember(3)]
		public List<ChallengeStructV2> challenge_list{ get; set; }
		[ProtoMember(4)]
		public SmartPhoneSettingsStructV2 smart_phone{ get; set; }
		[ProtoMember(5)]
		public string quick_shop_url{ get; set; }
		[ProtoMember(6)]
		public string quick_shop_name{ get; set; }
		[ProtoMember(7)]
		public string site_id{ get; set; }
	}
}