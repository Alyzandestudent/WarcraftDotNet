using System.Collections.Generic;
using System.Threading.Tasks;
using WarcraftDotNet.Legacy.API.Achievement;
using WarcraftDotNet.Legacy.API.Auction;
using WarcraftDotNet.Legacy.API.Boss;
using WarcraftDotNet.Legacy.API.CharacterProfile;
using WarcraftDotNet.Legacy.API.Guild;
using WarcraftDotNet.Legacy.API.Item;
using WarcraftDotNet.Legacy.API.Mount;
using WarcraftDotNet.Legacy.API.Pet;
using WarcraftDotNet.Legacy.API.PVP;
using WarcraftDotNet.Legacy.API.Quest;
using WarcraftDotNet.Legacy.API.RealmStatus;
using WarcraftDotNet.Legacy.API.Recipe;
using WarcraftDotNet.Legacy.API.Spell;
using WarcraftDotNet.Legacy.API.Zone;

namespace WarcraftDotNet.Legacy.Interfaces
{
    public interface IWarcraftClient
    {
        Task<Achievement> GetAchievementAsync(int achievementId);
        Task<List<AuctionData>> GetAuctionData(string realm);
        Task<BossData> GetBossesAsync();
        Task<API.Boss.Boss> GetBossAsync(int bossId);
        Task<CharacterProfile> GetCharacterProfileAsync(string realm, string name, IEnumerable<string> fields);
        Task<Guild> GetGuildAsync(string realm, string name, IEnumerable<string> fields);
        Task<Item> GetItemAsync(int itemId);
        Task<ItemSet> GetItemSetAsync(int setId);
        Task<Mounts> GetMountsAsync();
        Task<Pets> GetPetsAsync();
        Task<PetAbility> GetPetAbilityAsync(int abilityId);
        Task<Species> GetPetSpeciesAsync(int speciesId);
        Task<Stats> GetPetSpeciesStatsAsync(int speciesId);
        Task<Leaderboard> GetLeaderboardAsync(string bracket);
        Task<Quest> GetQuestAsync(int questId);
        Task<Realms> GetRealmStatusesAsync();
        Task<Recipe> GetRecipeAsync(int recipeId);
        Task<Spell> GetSpellAsync(int spellId);
        Task<Zones> GetZonesAsync();
        Task<Zone> GetZoneAsync(int zoneId);
    }
}