using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Auction
{
    public class Modifier
    {
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}