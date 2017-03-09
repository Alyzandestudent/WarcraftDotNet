using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.Pet
{
    public class Pets
    {
        [JsonProperty("pets")]
        public List<Pet> PetList { get; set; }
    }
}