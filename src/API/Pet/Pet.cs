using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.Pet
{
    public class Pet
    {
        [JsonProperty("canBattle")]
        public bool CanBattle { get; set; }
        [JsonProperty("creatureId")]
        public int CreatureId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("family")]
        public string Family { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("qualityId")]
        public int QualityId { get; set; }
        [JsonProperty("stats")]
        public Stats Stats { get; set; }
        [JsonProperty("strongAgainst")]
        public List<string> StrongAgainst { get; set; }
        [JsonProperty("typeId")]
        public int TypeId { get; set; }
        [JsonProperty("weakAgainst")]
        public List<string> WeakAgainst { get; set; }
    }
}