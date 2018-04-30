using Newtonsoft.Json;

namespace WarcraftDotNet.API.Pet
{
    public class SpeciesAbility
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }
        [JsonProperty("order")]
        public int Order { get; set; }
        [JsonProperty("requiredLevel")]
        public int RequiredLevel { get; set; }
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