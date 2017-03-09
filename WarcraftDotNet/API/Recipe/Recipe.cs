using Newtonsoft.Json;

namespace WarcraftDotNet.API.Recipe
{
    public class Recipe
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("profession")]
        public string Profession { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}
