using Newtonsoft.Json; 
namespace TikTokForWindows { 

    public class Stats    {
        [JsonProperty("diggCount")]
        public int DiggCount { get; set; } 

        [JsonProperty("shareCount")]
        public int ShareCount { get; set; } 

        [JsonProperty("commentCount")]
        public int CommentCount { get; set; } 

        [JsonProperty("playCount")]
        public int PlayCount { get; set; } 
    }

}