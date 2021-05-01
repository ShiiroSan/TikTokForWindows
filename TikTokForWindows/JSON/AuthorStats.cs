using Newtonsoft.Json; 
namespace TikTokForWindows { 

    public class AuthorStats    {
        [JsonProperty("followingCount")]
        public int FollowingCount { get; set; } 

        [JsonProperty("followerCount")]
        public int FollowerCount { get; set; } 

        [JsonProperty("heartCount")]
        public int HeartCount { get; set; } 

        [JsonProperty("videoCount")]
        public int VideoCount { get; set; } 

        [JsonProperty("diggCount")]
        public int DiggCount { get; set; } 

        [JsonProperty("heart")]
        public int Heart { get; set; } 
    }

}