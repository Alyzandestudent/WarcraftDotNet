using Newtonsoft.Json;

namespace WarcraftDotNet.API.Item
{
    public class BonusStat
    {
        [JsonProperty("stat")]
        public int Stat { get; set; }
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}