using Newtonsoft.Json; 
namespace TikTokForWindows { 

    public class Author    {
        [JsonProperty("id")]
        public string Id { get; set; } 

        [JsonProperty("uniqueId")]
        public string UniqueId { get; set; } 

        [JsonProperty("nickname")]
        public string Nickname { get; set; } 

        [JsonProperty("avatarThumb")]
        public string AvatarThumb { get; set; } 

        [JsonProperty("avatarMedium")]
        public string AvatarMedium { get; set; } 

        [JsonProperty("avatarLarger")]
        public string AvatarLarger { get; set; } 

        [JsonProperty("signature")]
        public string Signature { get; set; } 

        [JsonProperty("verified")]
        public bool Verified { get; set; } 

        [JsonProperty("secUid")]
        public string SecUid { get; set; } 

        [JsonProperty("secret")]
        public bool Secret { get; set; } 

        [JsonProperty("ftc")]
        public bool Ftc { get; set; } 

        [JsonProperty("relation")]
        public int Relation { get; set; } 

        [JsonProperty("openFavorite")]
        public bool OpenFavorite { get; set; } 

        [JsonProperty("commentSetting")]
        public int CommentSetting { get; set; } 

        [JsonProperty("duetSetting")]
        public int DuetSetting { get; set; } 

        [JsonProperty("stitchSetting")]
        public int StitchSetting { get; set; } 

        [JsonProperty("privateAccount")]
        public bool PrivateAccount { get; set; } 
    }

}