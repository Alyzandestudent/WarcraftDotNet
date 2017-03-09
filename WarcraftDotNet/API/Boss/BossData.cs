using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.Boss
{
    public class BossData
    {
        [JsonProperty("bosses")]
        public List<Boss> Bosses { get; set; }
    }
}