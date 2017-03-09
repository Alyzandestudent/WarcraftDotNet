using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.Guild
{
    public class RewardInfo
    {
        [JsonProperty("minGuildLevel")]
        public int MinGuildLevel { get; set; }
        [JsonProperty("minGuildRepLevel")]
        public int MinGuildRepLevel { get; set; }
        [JsonProperty("races")]
        public List<int> Races { get; set; }
        [JsonProperty("achievement")]
        public RewardAchievementInfo Achievement { get; set; }
        [JsonProperty("item")]
        public RewardItemInfo Item { get; set; }
    }
}
