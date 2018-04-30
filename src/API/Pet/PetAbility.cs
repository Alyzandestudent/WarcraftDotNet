using Newtonsoft.Json;

namespace WarcraftDotNet.API.Pet
{
    public class PetAbility
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("cooldown")]
        public int Cooldown { get; set; }
        [JsonProperty("rounds")]
        public int Rounds { get; set; }
        [JsonProperty("petTypeId")]
        public int PetTypeId { get; set; }
        [JsonProperty("isPassive")]
        public bool IsPassive { get; set; }
        [JsonProperty("hideHints")]
        public bool HideHints { get; set; }
    }
}