using Newtonsoft.Json;

namespace WarcraftDotNet.API.Auction
{
    public class File
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("lastModified")]
        public long LastModified { get; set; }
    }
}