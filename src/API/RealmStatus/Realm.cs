using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.API.RealmStatus
{
    public class Realm
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("population")]
        public string Population { get; set; }
        [JsonProperty("queue")]
        public bool Queue { get; set; }
        [JsonProperty("status")]
        public bool Status { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("battlegroup")]
        public string Battlegroup { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        [JsonProperty("connectedRealms")]
        public List<string> ConnectedRealms { get; set; }
    }
}