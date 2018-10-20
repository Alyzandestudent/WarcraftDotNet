using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.CharacterProfile
{
    public class Achievements
    {
        [JsonProperty("achievementsCompleted")]
        public List<int> AchievementsCompleted { get; set; }
        [JsonProperty("achievementsCompletedTimestamp")]
        public List<object> AchievementsCompletedTimestamp { get; set; }
        [JsonProperty("criteria ")]
        public List<int> Criteria { get; set; }
        [JsonProperty("criteriaQuantity")]
        public List<object> CriteriaQuantity { get; set; }
        [JsonProperty("criteriaTimestamp")]
        public List<object> CriteriaTimestamp { get; set; }
        [JsonProperty("criteriaCreated")]
        public List<object> CriteriaCreated { get; set; }
    }
}