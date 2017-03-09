using Newtonsoft.Json;

namespace WarcraftDotNet.API.CharacterProfile
{
    public class Boss
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        // ReSharper disable once InconsistentNaming
        [JsonProperty("lfrKills")]
        public int? LFRKills { get; set; }
        // ReSharper disable once InconsistentNaming
        [JsonProperty("lfrTimestamp")]
        public long? LFRTimestamp { get; set; }
        [JsonProperty("normalKills")]
        public int? NormalKills { get; set; }
        [JsonProperty("normalTimestamp")]
        public long? NormalTimestamp { get; set; }
        [JsonProperty("heroicKills")]
        public int? HeroicKills { get; set; }
        [JsonProperty("heroicTimestamp")]
        public long? HeroicTimestamp { get; set; }
        [JsonProperty("mythicKills")]
        public int? MythicKills { get; set; }
        [JsonProperty("mythicTimestamp")]
        public long? MythicTimestamp { get; set; }
    }
}
