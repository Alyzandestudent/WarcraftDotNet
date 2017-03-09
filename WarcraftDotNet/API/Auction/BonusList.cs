using Newtonsoft.Json;

namespace WarcraftDotNet.API.Auction
{
    public class BonusList
    {
        [JsonProperty("bonusListId")]
        public int BonusListId { get; set; }
    }
}