using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Achievement
{
    public class Achievement
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("points")]
        public int Points { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("reward")]
        public string Reward { get; set; }
        [JsonProperty("rewardItems")]
        public List<RewardItem> RewardItems { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("criteria")]
        public List<Criterion> Criteria { get; set; }
        [JsonProperty("accountWide")]
        public bool AccountWide { get; set; }
        [JsonProperty("factionId")]
        public int FactionId { get; set; }
    }
}