using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Guild
{
    public class RewardAchievementInfo
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
        [JsonProperty("rewardItem")]
        public RewardItemInfo RewardItem { get; set; }

    }
}