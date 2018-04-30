using Newtonsoft.Json;

namespace WarcraftDotNet.API.PVP
{
    public class Row
    {
        [JsonProperty("ranking")]
        public int Ranking { get; set; }
        [JsonProperty("rating")]
        public int Rating { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("realmId")]
        public int RealmId { get; set; }
        [JsonProperty("realmName")]
        public string RealmName { get; set; }
        [JsonProperty("realmSlug")]
        public string RealmSlug { get; set; }
        [JsonProperty("raceId")]
        public int RaceId { get; set; }
        [JsonProperty("classId")]
        public int ClassId { get; set; }
        [JsonProperty("specId")]
        public int SpecId { get; set; }
        [JsonProperty("factionId")]
        public int FactionId { get; set; }
        [JsonProperty("genderId")]
        public int GenderId { get; set; }
        [JsonProperty("seasonWins")]
        public int SeasonWins { get; set; }
        [JsonProperty("seasonLosses")]
        public int SeasonLosses { get; set; }
        [JsonProperty("weeklyWins")]
        public int WeeklyWins { get; set; }
        [JsonProperty("weeklyLosses")]
        public int WeeklyLosses { get; set; }
    }
}