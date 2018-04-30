using Newtonsoft.Json;

namespace WarcraftDotNet.API.Item
{
    public class SetBonus
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("threshold")]
        public int Threshold { get; set; }
    }
}