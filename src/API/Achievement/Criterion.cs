using Newtonsoft.Json;

namespace WarcraftDotNet.API.Achievement
{
    public class Criterion
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("orderIndex")]
        public int OrderIndex { get; set; }
        [JsonProperty("max")]
        public int Max { get; set; }
    }
}