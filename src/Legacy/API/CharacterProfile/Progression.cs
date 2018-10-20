using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.CharacterProfile
{
    public class Progression
    {
        [JsonProperty("raids")]
        public List<Raid> Raids { get; set; }
    }
}