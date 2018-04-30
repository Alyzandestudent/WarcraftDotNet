using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.Guild
{
    public class RewardsData
    {
        [JsonProperty("rewards")]
        public List<RewardInfo> Rewards { get; set; }
    }
}