using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Achievement
{
    public class TooltipParams
    {
        [JsonProperty("timewalkerLevel")]
        public int TimewalkerLevel { get; set; }
    }
}