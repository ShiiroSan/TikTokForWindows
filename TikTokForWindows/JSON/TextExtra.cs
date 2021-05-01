using Newtonsoft.Json; 
namespace TikTokForWindows { 

    public class TextExtra    {
        [JsonProperty("awemeId")]
        public string AwemeId { get; set; } 

        [JsonProperty("start")]
        public int Start { get; set; } 

        [JsonProperty("end")]
        public int End { get; set; } 

        [JsonProperty("hashtagName")]
        public string HashtagName { get; set; } 

        [JsonProperty("hashtagId")]
        public string HashtagId { get; set; } 

        [JsonProperty("type")]
        public int Type { get; set; } 

        [JsonProperty("userId")]
        public string UserId { get; set; } 

        [JsonProperty("isCommerce")]
        public bool IsCommerce { get; set; } 

        [JsonProperty("userUniqueId")]
        public string UserUniqueId { get; set; } 

        [JsonProperty("secUid")]
        public string SecUid { get; set; } 
    }

}