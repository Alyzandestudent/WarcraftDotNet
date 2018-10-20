using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Mount
{
    public class Mounts
    {
        [JsonProperty("mounts")]
        public List<Mount> MountList { get; set; }
    }
}