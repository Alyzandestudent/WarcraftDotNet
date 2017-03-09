using Newtonsoft.Json;

namespace WarcraftDotNet.API.Guild
{
    public class Emblem
    {
        [JsonProperty("icon")]
        public int Icon { get; set; }
        [JsonProperty("iconColor")]
        public string IconColor { get; set; }
        [JsonProperty("border")]
        public int Border { get; set; }
        [JsonProperty("borderColor")]
        public string BorderColor { get; set; }
        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
    }
}
