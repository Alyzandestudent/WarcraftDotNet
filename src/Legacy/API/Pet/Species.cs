using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Pet
{
    public class Species
    {
        [JsonProperty("speciesId")]
        public int SpeciesId { get; set; }
        [JsonProperty("petTypeId ")]
        public int PetTypeId { get; set; }
        [JsonProperty("creatureId")]
        public int CreatureId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("canBattle")]
        public string CanBattle { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("abilities")]
        public List<SpeciesAbility> Abilities { get; set; }
    }
}