﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.PVP
{
    public class Leaderboard
    {
        [JsonProperty("rows")]
        public List<Row> Rows { get; set; }
    }
}