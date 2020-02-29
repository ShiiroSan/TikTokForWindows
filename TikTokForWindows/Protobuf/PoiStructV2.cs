using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class PoiStructV2 {
		[ProtoMember(1)]
		public string poi_id{ get; set; }
		[ProtoMember(2)]
		public string poi_name{ get; set; }
		[ProtoMember(3)]
		public string type_code{ get; set; }
		[ProtoMember(4)]
		public int user_count{ get; set; }
		[ProtoMember(5)]
		public int item_count{ get; set; }
		[ProtoMember(6)]
		public ShareStructV2 share_info{ get; set; }
		[ProtoMember(7)]
		public UrlStructV2 cover_hd{ get; set; }
		[ProtoMember(8)]
		public UrlStructV2 cover_large{ get; set; }
		[ProtoMember(9)]
		public UrlStructV2 cover_medium{ get; set; }
		[ProtoMember(10)]
		public UrlStructV2 cover_thumb{ get; set; }
		[ProtoMember(11)]
		public string distance{ get; set; }
		[ProtoMember(12)]
		public AddressStructV2 address_info{ get; set; }
		[ProtoMember(13)]
		public int icon_type{ get; set; }
		[ProtoMember(14)]
		public int collect_stat{ get; set; }
		[ProtoMember(15)]
		public double poi_longitude{ get; set; }
		[ProtoMember(16)]
		public double poi_latitude{ get; set; }
		[ProtoMember(17)]
		public int expand_type{ get; set; }
		[ProtoMember(18)]
		public UrlStructV2 icon_on_map{ get; set; }
		[ProtoMember(19)]
		public UrlStructV2 icon_on_entry{ get; set; }
		[ProtoMember(20)]
		public UrlStructV2 icon_on_info{ get; set; }
		[ProtoMember(21)]
		public int poi_type{ get; set; }
		[ProtoMember(22)]
		public string poi_voucher{ get; set; }
		[ProtoMember(23)]
		public double rating{ get; set; }
		[ProtoMember(24)]
		public double cost{ get; set; }
		[ProtoMember(25)]
		public string poi_rank_desc{ get; set; }
		[ProtoMember(26)]
		public string business_area_name{ get; set; }
		[ProtoMember(27)]
		public bool is_local_city{ get; set; }
		[ProtoMember(28)]
		public string option_name{ get; set; }
		[ProtoMember(29)]
		public string poi_subtitle{ get; set; }
		[ProtoMember(30)]
		public string sp_source{ get; set; }
		[ProtoMember(31)]
		public int show_type{ get; set; }
		[ProtoMember(32)]
		public bool is_candidate{ get; set; }
		[ProtoMember(33)]
		public PoiCardStructV2 poi_card{ get; set; }
		[ProtoMember(34)]
		public int poi_subtitle_type{ get; set; }
		[ProtoMember(35)]
		public List<string> voucher_release_areas{ get; set; }
		[ProtoMember(36)]
		public int is_show_halfcard{ get; set; }
		[ProtoMember(37)]
		public List<PoiFrontendTypeStructV2> poi_frontend_type{ get; set; }
		[ProtoMember(38)]
		public PoiBackendTypeStructV2 poi_backend_type{ get; set; }
		[ProtoMember(39)]
		public UrlStructV2 cover_item{ get; set; }
		[ProtoMember(40)]
		public bool is_top_recommend{ get; set; }
		[ProtoMember(41)]
		public bool is_admin_area{ get; set; }
		[ProtoMember(42)]
		public string collected_count{ get; set; }
		[ProtoMember(43)]
		public string view_count{ get; set; }
	}
}