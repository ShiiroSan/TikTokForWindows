using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class AwemePromotionOtherStructV2 {
		[ProtoMember(1)]
		public string recall_reason{ get; set; }
		[ProtoMember(2)]
		public int card_predict_duration{ get; set; }
		[ProtoMember(3)]
		public bool order_share_recommend{ get; set; }
	}
}