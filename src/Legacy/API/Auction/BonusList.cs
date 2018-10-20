using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Auction
{
    public class BonusList
    {
        [JsonProperty("bonusListId")]
        public int BonusListId { get; set; }
    }
}