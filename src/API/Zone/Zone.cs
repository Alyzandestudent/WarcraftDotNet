using System.Collections.Generic;
using Newtonsoft.Json;
using WarcraftDotNet.API.Boss;

namespace WarcraftDotNet.API.Zone
{
    public class Zone
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("urlSlug")]
        public string UrlSlug { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("expansionId")]
        public int ExpansionId { get; set; }
        [JsonProperty("numPlayers")]
        public string NumPlayers { get; set; }
        [JsonProperty("isDungeon")]
        public bool IsDungeon { get; set; }
        [JsonProperty("isRaid")]
        public bool IsRaid { get; set; }
        [JsonProperty("advisedMinLevel")]
        public int AdvisedMinLevel { get; set; }
        [JsonProperty("advisedMaxLevel")]
        public int AdvisedMaxLevel { get; set; }
        [JsonProperty("advisedHeroicMinLevel")]
        public int AdvisedHeroicMinLevel { get; set; }
        [JsonProperty("advisedHeroicMaxLevel")]
        public int AdvisedHeroicMaxLevel { get; set; }
        [JsonProperty("availableModes")]
        public List<object> AvailableModes { get; set; }
        [JsonProperty("lfgNormalMinGearLevel")]
        public int LfgNormalMinGearLevel { get; set; }
        [JsonProperty("lfgHeroicMinGearLevel")]
        public int LfgHeroicMinGearLevel { get; set; }
        [JsonProperty("floors")]
        public int Floors { get; set; }
        [JsonProperty("bosses")]
        public List<Boss.Boss> Bosses { get; set; }
        [JsonProperty("patch")]
        public string Patch { get; set; }
    }
}