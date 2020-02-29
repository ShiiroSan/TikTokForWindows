using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class CommentStructV2 {
		[ProtoMember(1)]
		public string cid{ get; set; }
		[ProtoMember(2)]
		public string text{ get; set; }
		[ProtoMember(3)]
		public string aweme_id{ get; set; }
		[ProtoMember(4)]
		public long create_time{ get; set; }
		[ProtoMember(5)]
		public int digg_count{ get; set; }
		[ProtoMember(6)]
		public int status{ get; set; }
		[ProtoMember(7)]
		public UserStructV2 user{ get; set; }
		[ProtoMember(8)]
		public string reply_id{ get; set; }
		[ProtoMember(9)]
		public int user_digged{ get; set; }
		[ProtoMember(10)]
		public List<CommentStructV2> reply_comment{ get; set; }
		[ProtoMember(11)]
		public List<TextExtraStructV2> text_extra{ get; set; }
		[ProtoMember(12)]
		public string label_text{ get; set; }
		[ProtoMember(13)]
		public int label_type{ get; set; }
		[ProtoMember(14)]
		public RelationDynamicLableStructV2 relation_label{ get; set; }
		[ProtoMember(15)]
		public string forward_id{ get; set; }
		[ProtoMember(16)]
		public int reply_comment_total{ get; set; }
		[ProtoMember(17)]
		public string reply_to_reply_id{ get; set; }
		[ProtoMember(18)]
		public string reply_to_username{ get; set; }
		[ProtoMember(19)]
		public string reply_to_userid{ get; set; }
		[ProtoMember(20)]
		public bool is_author_digged{ get; set; }
	}
}