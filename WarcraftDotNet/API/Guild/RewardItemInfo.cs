using Newtonsoft.Json;
using WarcraftDotNet.API.Achievement;

namespace WarcraftDotNet.API.Guild
{
    public class RewardItemInfo
    {     
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("quality")]
        public int Quality { get; set; }
        [JsonProperty("tooltipParams")]
        public TooltipParams TooltipParams { get; set; }
    }
}
