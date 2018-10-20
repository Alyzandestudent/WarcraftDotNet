using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Item
{
    public class Damage
    {
        [JsonProperty("min")]
        public int Min { get; set; }
        [JsonProperty("max")]
        public int Max { get; set; }
        [JsonProperty("exactMin")]
        public double ExactMin { get; set; }
        [JsonProperty("exactMax")]
        public double ExactMax { get; set; }
    }
}