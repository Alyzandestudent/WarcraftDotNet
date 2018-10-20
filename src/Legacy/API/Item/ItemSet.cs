using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Item
{
    public class ItemSet
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("setBonuses")]
        public List<SetBonus> SetBonuses { get; set; }
        [JsonProperty("items")]
        public List<int> Items { get; set; }
    }
}