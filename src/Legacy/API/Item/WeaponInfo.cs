using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Item
{
    public class WeaponInfo
    {
        [JsonProperty("damage")]
        public Damage Damage { get; set; }
        [JsonProperty("weaponSpeed")]
        public double WeaponSpeed { get; set; }
        [JsonProperty("dps")]
        public double Dps { get; set; }
    }
}