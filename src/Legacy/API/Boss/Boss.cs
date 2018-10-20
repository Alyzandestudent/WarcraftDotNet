using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Boss
{
    public class Boss
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("urlSlug")]
        public string UrlSlug { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("zoneId")]
        public int ZoneId { get; set; }
        [JsonProperty("availableInNormalMode")]
        public bool AvailableInNormalMode { get; set; }
        [JsonProperty("availableInHeroicMode")]
        public bool AvailableInHeroicMode { get; set; }
        [JsonProperty("health")]
        public int Health { get; set; }
        [JsonProperty("heroicHealth")]
        public int HeroicHealth { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("heroicLevel")]
        public int HeroicLevel { get; set; }
        [JsonProperty("journalId")]
        public int JournalId { get; set; }
        [JsonProperty("npcs")]
        public List<NPC> Npcs { get; set; }
    }
}