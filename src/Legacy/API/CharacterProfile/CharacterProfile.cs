using Newtonsoft.Json;
using WarcraftDotNet.Legacy.Enum;

namespace WarcraftDotNet.Legacy.API.CharacterProfile
{
    public class CharacterProfile
    {
        [JsonProperty("lastModified")]
        public long LastModified { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("realm")]
        public string Realm { get; set; }
        [JsonProperty("battlegroup")]
        public string Battlegroup { get; set; }
        [JsonProperty("class")]
        public ClassEnum CharacterClass { get; set; }
        [JsonProperty("race")]
        public RaceEnum Race { get; set; }
        [JsonProperty("gender")]
        public GenderEnum Gender { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        [JsonProperty("calcClass")]
        public string CalcClass { get; set; }
        [JsonProperty("faction")]
        public int Faction { get; set; }
        [JsonProperty("achievements")]
        public Achievements Achievements { get; set; }
        [JsonProperty("totalHonorableKills")]
        public int TotalHonorableKills { get; set; }
        [JsonProperty("progression")]
        public Progression Progression { get; set; }
    }
}