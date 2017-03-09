using Newtonsoft.Json;

namespace WarcraftDotNet.API.Boss
{
    // ReSharper disable once InconsistentNaming
    public class NPC
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("urlSlug")]
        public string UrlSlug { get; set; }
    }
}