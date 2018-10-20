using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Auction
{
    public class Files
    {
        [JsonProperty("files")]
        public List<File> FileList { get; set; }
    }
}