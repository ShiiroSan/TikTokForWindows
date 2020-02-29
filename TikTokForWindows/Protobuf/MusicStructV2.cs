using ProtoBuf;
using System.Collections.Generic;

namespace TikTokForWindows {
	[ProtoContract]
	class MusicStructV2 {
		[ProtoMember(1)]
		public long id{ get; set; }
		[ProtoMember(2)]
		public string id_str{ get; set; }
		[ProtoMember(3)]
		public string title{ get; set; }
		[ProtoMember(4)]
		public string author{ get; set; }
		[ProtoMember(5)]
		public string album{ get; set; }
		[ProtoMember(6)]
		public UrlStructV2 cover_hd{ get; set; }
		[ProtoMember(7)]
		public UrlStructV2 cover_large{ get; set; }
		[ProtoMember(8)]
		public UrlStructV2 cover_medium{ get; set; }
		[ProtoMember(9)]
		public UrlStructV2 cover_thumb{ get; set; }
		[ProtoMember(10)]
		public UrlStructV2 play_url{ get; set; }
		[ProtoMember(11)]
		public string schema_url{ get; set; }
		[ProtoMember(12)]
		public int source_platform{ get; set; }
		[ProtoMember(13)]
		public int start_time{ get; set; }
		[ProtoMember(14)]
		public int end_time{ get; set; }
		[ProtoMember(15)]
		public int duration{ get; set; }
		[ProtoMember(16)]
		public string extra{ get; set; }
		[ProtoMember(17)]
		public int user_count{ get; set; }
		[ProtoMember(18)]
		public List<PositionStructV2> position{ get; set; }
		[ProtoMember(19)]
		public ShareStructV2 share_info{ get; set; }
		[ProtoMember(20)]
		public int collect_stat{ get; set; }
		[ProtoMember(21)]
		public int status{ get; set; }
		[ProtoMember(22)]
		public string offline_desc{ get; set; }
		[ProtoMember(23)]
		public UrlStructV2 effects_data{ get; set; }
		[ProtoMember(24)]
		public string owner_id{ get; set; }
		[ProtoMember(25)]
		public string owner_nickname{ get; set; }
		[ProtoMember(26)]
		public string use_count_desc{ get; set; }
		[ProtoMember(27)]
		public UrlStructV2 audio_track{ get; set; }
		[ProtoMember(28)]
		public UrlStructV2 bodydance_url{ get; set; }
		[ProtoMember(29)]
		public ChallengeStructV2 bodydance_challenge{ get; set; }
		[ProtoMember(30)]
		public bool is_original{ get; set; }
		[ProtoMember(31)]
		public ChallengeStructV2 challenge{ get; set; }
		[ProtoMember(32)]
		public int billboard_rank{ get; set; }
		[ProtoMember(33)]
		public string mid{ get; set; }
		[ProtoMember(34)]
		public UrlStructV2 bodydance_challenge_id{ get; set; }
		[ProtoMember(35)]
		public long binded_challenge_id{ get; set; }
		[ProtoMember(36)]
		public bool redirect{ get; set; }
		[ProtoMember(37)]
		public bool is_restricted{ get; set; }
		[ProtoMember(38)]
		public bool author_deleted{ get; set; }
		[ProtoMember(39)]
		public bool is_del_video{ get; set; }
		[ProtoMember(40)]
		public bool is_video_self_see{ get; set; }
		[ProtoMember(41)]
		public string owner_handle{ get; set; }
		[ProtoMember(42)]
		public List<PositionStructV2> author_position{ get; set; }
		[ProtoMember(43)]
		public bool prevent_download{ get; set; }
		[ProtoMember(44)]
		public int music_billboard_type{ get; set; }
		[ProtoMember(45)]
		public BranchBillboardWeeklyStructV2 music_billboard_weekly_info{ get; set; }
		[ProtoMember(46)]
		public CategoryCoverStructV2 category_cover_info{ get; set; }
		[ProtoMember(47)]
		public bool is_only_owner_use{ get; set; }
		[ProtoMember(48)]
		public bool is_video_not_recommend{ get; set; }
		[ProtoMember(49)]
		public UrlStructV2 strong_beat_url{ get; set; }
		[ProtoMember(50)]
		public List<string> unshelve_countries{ get; set; }
		[ProtoMember(51)]
		public int prevent_item_download_status{ get; set; }
		[ProtoMember(52)]
		public List<ExternalSongStructV2> external_song_info{ get; set; }
		[ProtoMember(53)]
		public string sec_uid{ get; set; }
		[ProtoMember(54)]
		public int lyric_type{ get; set; }
		[ProtoMember(55)]
		public string lyric_url{ get; set; }
		[ProtoMember(56)]
		public UrlStructV2 avatar_thumb{ get; set; }
		[ProtoMember(57)]
		public UrlStructV2 avatar_medium{ get; set; }
		[ProtoMember(58)]
		public UrlStructV2 avatar_large{ get; set; }
		[ProtoMember(59)]
		public double preview_start_time{ get; set; }
		[ProtoMember(60)]
		public double preview_end_time{ get; set; }
		[ProtoMember(61)]
		public long cluster_id{ get; set; }
		[ProtoMember(62)]
		public bool mute_share{ get; set; }
	}
}