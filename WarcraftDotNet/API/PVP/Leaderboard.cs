using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.PVP
{
    public class Leaderboard
    {
        [JsonProperty("rows")]
        public List<Row> Rows { get; set; }
    }
}
