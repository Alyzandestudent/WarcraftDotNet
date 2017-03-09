﻿using Newtonsoft.Json;

namespace WarcraftDotNet.API.Boss
{
    public class Location
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}