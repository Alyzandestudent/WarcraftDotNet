using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.Item
{
    public class BonusSummary
    {
        [JsonProperty("defaultBonusLists")]
        public List<object> DefaultBonusLists { get; set; }
        [JsonProperty("changeBonusLists ")]
        public List<object> ChangeBonusLists { get; set; }
        [JsonProperty("bonusChances")]
        public List<object> BonusChances { get; set; }
    }
}