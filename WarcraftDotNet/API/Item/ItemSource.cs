using Newtonsoft.Json;

namespace WarcraftDotNet.API.Item
{
    public class ItemSource
    {
        [JsonProperty("sourceId")]
        public int SourceId { get; set; }
        [JsonProperty("sourceType")]
        public string SourceType { get; set; }
    }
}