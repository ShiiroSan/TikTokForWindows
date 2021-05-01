using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace TikTokForWindows { 

    public class StickersOnItem    {
        [JsonProperty("stickerType")]
        public int StickerType { get; set; } 

        [JsonProperty("stickerText")]
        public List<string> StickerText { get; set; } 
    }

}