using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.RealmStatus
{
    public class Realms
    {
        [JsonProperty("realms")]
        public List<Realm> RealmList { get; set; }
    }
}