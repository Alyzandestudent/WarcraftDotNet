using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Auction
{
    public class File
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("lastModified")]
        public long LastModified { get; set; }
    }
}