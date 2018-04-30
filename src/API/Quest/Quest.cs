using Newtonsoft.Json;

namespace WarcraftDotNet.API.Quest
{
    public class Quest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("reqLevel")]
        public int ReqLevel { get; set; }
        [JsonProperty("suggestedPartyMembers ")]
        public int SuggestedPartyMembers { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
    }
}