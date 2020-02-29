using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class PromotionStructV2 {
		[ProtoMember(1)]
		public string promotion_id{ get; set; }
		[ProtoMember(2)]
		public string gid{ get; set; }
		[ProtoMember(3)]
		public string title{ get; set; }
		[ProtoMember(4)]
		public UrlStructV2 image{ get; set; }
		[ProtoMember(5)]
		public long price{ get; set; }
		[ProtoMember(6)]
		public long market_price{ get; set; }
		[ProtoMember(7)]
		public long cos_fee{ get; set; }
		[ProtoMember(8)]
		public string url{ get; set; }
		[ProtoMember(9)]
		public long item_type{ get; set; }
		[ProtoMember(10)]
		public long sales{ get; set; }
		[ProtoMember(11)]
		public string extra{ get; set; }
		[ProtoMember(12)]
		public bool favorited{ get; set; }
		[ProtoMember(13)]
		public string last_aweme_id{ get; set; }
		[ProtoMember(14)]
		public string elastic_title{ get; set; }
		[ProtoMember(15)]
		public string elastic_introduction{ get; set; }
		[ProtoMember(16)]
		public List<UrlStructV2> elastic_img{ get; set; }
		[ProtoMember(17)]
		public List<string> label{ get; set; }
		[ProtoMember(18)]
		public PromotionVisitorV2 visitor{ get; set; }
		[ProtoMember(19)]
		public string h5_url{ get; set; }
		[ProtoMember(20)]
		public double cos_radio{ get; set; }
		[ProtoMember(21)]
		public string logo{ get; set; }
		[ProtoMember(22)]
		public string source{ get; set; }
		[ProtoMember(23)]
		public List<UrlStructV2> imgs{ get; set; }
		[ProtoMember(24)]
		public int promotion_source{ get; set; }
		[ProtoMember(25)]
		public int elastic_type{ get; set; }
		[ProtoMember(26)]
		public string title_prefix{ get; set; }
		[ProtoMember(27)]
		public int views{ get; set; }
		[ProtoMember(28)]
		public int clicks{ get; set; }
		[ProtoMember(29)]
		public int rank{ get; set; }
		[ProtoMember(30)]
		public string rank_url{ get; set; }
		[ProtoMember(31)]
		public string trace_author_id{ get; set; }
		[ProtoMember(32)]
		public string trace_aweme_id{ get; set; }
		[ProtoMember(33)]
		public UrlStructV2 brand_icon{ get; set; }
		[ProtoMember(34)]
		public string small_app_url{ get; set; }
		[ProtoMember(35)]
		public List<UserShopCategoryV2> user_shop_categories{ get; set; }
	}
}