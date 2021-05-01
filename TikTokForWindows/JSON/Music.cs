using Newtonsoft.Json; 
namespace TikTokForWindows { 

    public class Music    {
        [JsonProperty("id")]
        public string Id { get; set; } 

        [JsonProperty("title")]
        public string Title { get; set; } 

        [JsonProperty("playUrl")]
        public string PlayUrl { get; set; } 

        [JsonProperty("coverThumb")]
        public string CoverThumb { get; set; } 

        [JsonProperty("coverMedium")]
        public string CoverMedium { get; set; } 

        [JsonProperty("coverLarge")]
        public string CoverLarge { get; set; } 

        [JsonProperty("authorName")]
        public string AuthorName { get; set; } 

        [JsonProperty("original")]
        public bool Original { get; set; } 

        [JsonProperty("duration")]
        public int Duration { get; set; } 

        [JsonProperty("album")]
        public string Album { get; set; } 
    }

}