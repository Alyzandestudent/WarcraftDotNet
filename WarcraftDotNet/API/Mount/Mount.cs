using Newtonsoft.Json;

namespace WarcraftDotNet.API.Mount
{
    public class Mount
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("spellId")]
        public int SpellId { get; set; }
        [JsonProperty("creatureId")]
        public int CreatureId { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("qualityId")]
        public int QualityId { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("isGround")]
        public bool IsGround { get; set; }
        [JsonProperty("isFlying")]
        public bool IsFlying { get; set; }
        [JsonProperty("isAquatic")]
        public bool IsAquatic { get; set; }
        [JsonProperty("isJumping")]
        public bool IsJumping { get; set; }
    }
}
