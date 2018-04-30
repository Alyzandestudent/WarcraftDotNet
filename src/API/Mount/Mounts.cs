using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.Mount
{
    public class Mounts
    {
        [JsonProperty("mounts")]
        public List<Mount> MountList { get; set; }
    }
}