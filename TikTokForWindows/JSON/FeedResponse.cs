using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace TikTokForWindows { 

    public class FeedResponse    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; } 

        [JsonProperty("itemList")]
        public List<AwemeStructV2> ItemList { get; set; } 

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; } 
    }

}