using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Achievement
{
    public class RewardItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("quality")]
        public int Quality { get; set; }
        [JsonProperty("itemLevel")]
        public int Itemlevel { get; set; }
        [JsonProperty("tooltipParams")]
        public TooltipParams TooltipParams { get; set; }
        [JsonProperty("stats")]
        public List<object> Stats { get; set; }
        [JsonProperty("armor")]
        public int Armor { get; set; }
        [JsonProperty("context")]
        public string Context { get; set; }
        [JsonProperty("bonusLists")]
        public List<object> BonusLists { get; set; }
    }
}