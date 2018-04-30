using Newtonsoft.Json;

namespace WarcraftDotNet.API.Auction
{
    public class Realm
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}