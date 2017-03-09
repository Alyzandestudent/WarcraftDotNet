using Newtonsoft.Json;

namespace WarcraftDotNet.API.Achievement
{
    public class TooltipParams
    {
        [JsonProperty("timewalkerLevel")]
        public int TimewalkerLevel { get; set; }
    }
}