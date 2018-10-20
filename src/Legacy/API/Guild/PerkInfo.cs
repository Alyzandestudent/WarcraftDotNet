using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Guild
{
    public class PerkInfo
    {
        [JsonProperty("guildLevel")]
        public int GuildLevel { get; set; }
        [JsonProperty("spell")]
        public PerkSpellInfo Spell { get; set; }

    }
}