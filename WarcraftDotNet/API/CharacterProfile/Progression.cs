using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.CharacterProfile
{
    public class Progression
    {
        [JsonProperty("raids")]
        public List<Raid> Raids { get; set; }
    }
}
