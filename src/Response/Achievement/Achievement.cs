using System.Collections.Generic;
using Newtonsoft.Json;
using WarcraftDotNet.Enums;

namespace WarcraftDotNet.Response.Achievement
{
    public class Achievement
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("points")]
        public int Points { get; set; }
        [JsonProperty("reward")]
        public string Reward { get; set; }
        // TODO: Add rewardItems
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("criteria")]
        public IEnumerable<Criteria> Criteria { get; set; }
        [JsonProperty("accountWide")]
        public bool AccountWide { get; set; }
        [JsonProperty("faction")]
        public FactionEnum Faction { get; set; }
    }
}