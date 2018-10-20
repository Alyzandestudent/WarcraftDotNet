using System.Collections.Generic;
using Newtonsoft.Json;
using WarcraftDotNet.Legacy.Enum;

namespace WarcraftDotNet.Legacy.API.Guild
{
    public class Guild
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("realm")]
        public string Realm { get; set; }
        [JsonProperty("battlegroup")]
        public string Battlegroup { get; set; }
        [JsonProperty("side")]
        public FactionEnum Side { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }
        [JsonProperty("lastModified")]
        public long LastModified { get; set; }
        [JsonProperty("emblem")]
        public Emblem Emblem { get; set; }
        [JsonProperty("members")]
        public List<Member> Members { get; set; }
        [JsonProperty("achievements")]
        public Achievements Achievements { get; set; }
        [JsonProperty("news")]
        public List<News> News { get; set; }
    }
}