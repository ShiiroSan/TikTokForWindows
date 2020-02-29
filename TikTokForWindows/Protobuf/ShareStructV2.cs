using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class ShareStructV2 {
		[ProtoMember(1)]
		public string share_url{ get; set; }
		[ProtoMember(2)]
		public string share_weibo_desc{ get; set; }
		[ProtoMember(3)]
		public string share_desc{ get; set; }
		[ProtoMember(4)]
		public string share_title{ get; set; }
		[ProtoMember(5)]
		public UrlStructV2 share_qrcode_url{ get; set; }
		[ProtoMember(6)]
		public string manage_goods_url{ get; set; }
		[ProtoMember(7)]
		public UrlStructV2 share_image_url{ get; set; }
		[ProtoMember(8)]
		public int bool_persist{ get; set; }
		[ProtoMember(9)]
		public string goods_rec_url{ get; set; }
		[ProtoMember(10)]
		public string share_title_myself{ get; set; }
		[ProtoMember(11)]
		public string share_title_other{ get; set; }
		[ProtoMember(12)]
		public string share_link_desc{ get; set; }
		[ProtoMember(13)]
		public string share_signature_url{ get; set; }
		[ProtoMember(14)]
		public string share_signature_desc{ get; set; }
		[ProtoMember(15)]
		public string share_quote{ get; set; }
		[ProtoMember(16)]
		public string whatsapp_desc{ get; set; }
	}
}