using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.Zone
{
    public class Zones
    {
        [JsonProperty("zones")]
        public List<Zone> ZoneList { get; set; }
    }
}