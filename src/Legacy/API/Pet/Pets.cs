using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Pet
{
    public class Pets
    {
        [JsonProperty("pets")]
        public List<Pet> PetList { get; set; }
    }
}