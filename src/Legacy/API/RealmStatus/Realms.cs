using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.RealmStatus
{
    public class Realms
    {
        [JsonProperty("realms")]
        public List<Realm> RealmList { get; set; }
    }
}