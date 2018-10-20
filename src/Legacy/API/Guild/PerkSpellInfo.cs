using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Guild
{
    public class PerkSpellInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("subtext")]
        public string Subtext { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}