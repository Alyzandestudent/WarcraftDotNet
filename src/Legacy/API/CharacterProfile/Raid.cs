using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.CharacterProfile
{
    public class Raid
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        // ReSharper disable once InconsistentNaming
        [JsonProperty("lfr")]
        public int? LFR { get; set; }
        [JsonProperty("normal")]
        public int? Normal { get; set; }
        [JsonProperty("heroic")]
        public int? Heroic { get; set; }
        [JsonProperty("mythic")]
        public int? Mythic { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("bosses")]
        public List<Boss> Bosses { get; set; }
    }
}