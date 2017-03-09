using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.Auction
{
    public class Files
    {
        [JsonProperty("files")]
        public List<File> FileList { get; set; }
    }
}