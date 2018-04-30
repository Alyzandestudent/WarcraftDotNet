using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.Guild
{
    public class PerksData
    {
        [JsonProperty("perks")]
        public List<PerkInfo> Perks { get; set; }
    }
}