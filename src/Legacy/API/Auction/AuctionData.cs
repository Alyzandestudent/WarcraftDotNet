using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Auction
{
    public class AuctionData
    {
        [JsonProperty("realms")] public List<Realm> Realms { get; set; }
        [JsonProperty("auctions")] public List<Auction> Auctions { get; set; }
    }
}