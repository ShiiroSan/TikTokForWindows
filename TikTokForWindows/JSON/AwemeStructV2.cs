using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace TikTokForWindows { 

    public class AwemeStructV2    {
        [JsonProperty("id")]
        public string Id { get; set; } 

        [JsonProperty("desc")]
        public string Desc { get; set; } 

        [JsonProperty("createTime")]
        public int CreateTime { get; set; } 

        [JsonProperty("video")]
        public Video Video { get; set; } 

        [JsonProperty("author")]
        public Author Author { get; set; } 

        [JsonProperty("music")]
        public Music Music { get; set; } 

        [JsonProperty("challenges")]
        public List<Challenge> Challenges { get; set; } 

        [JsonProperty("stats")]
        public Stats Stats { get; set; } 

        [JsonProperty("duetInfo")]
        public DuetInfo DuetInfo { get; set; } 

        [JsonProperty("originalItem")]
        public bool OriginalItem { get; set; } 

        [JsonProperty("officalItem")]
        public bool OfficalItem { get; set; } 

        [JsonProperty("textExtra")]
        public List<TextExtra> TextExtra { get; set; } 

        [JsonProperty("secret")]
        public bool Secret { get; set; } 

        [JsonProperty("forFriend")]
        public bool ForFriend { get; set; } 

        [JsonProperty("digged")]
        public bool Digged { get; set; } 

        [JsonProperty("itemCommentStatus")]
        public int ItemCommentStatus { get; set; } 

        [JsonProperty("showNotPass")]
        public bool ShowNotPass { get; set; } 

        [JsonProperty("vl1")]
        public bool Vl1 { get; set; } 

        [JsonProperty("itemMute")]
        public bool ItemMute { get; set; } 

        [JsonProperty("authorStats")]
        public AuthorStats AuthorStats { get; set; } 

        [JsonProperty("privateItem")]
        public bool PrivateItem { get; set; } 

        [JsonProperty("duetEnabled")]
        public bool DuetEnabled { get; set; } 

        [JsonProperty("stitchEnabled")]
        public bool StitchEnabled { get; set; } 

        [JsonProperty("shareEnabled")]
        public bool ShareEnabled { get; set; } 

        [JsonProperty("isAd")]
        public bool IsAd { get; set; } 

        [JsonProperty("stickersOnItem")]
        public List<StickersOnItem> StickersOnItem { get; set; } 
    }

}