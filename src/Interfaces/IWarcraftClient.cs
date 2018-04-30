using System.Collections.Generic;
using System.Threading.Tasks;
using WarcraftDotNet.API.Achievement;
using WarcraftDotNet.API.Auction;
using WarcraftDotNet.API.Boss;
using WarcraftDotNet.API.CharacterProfile;
using WarcraftDotNet.API.Guild;
using WarcraftDotNet.API.Item;
using WarcraftDotNet.API.Mount;
using WarcraftDotNet.API.Pet;
using WarcraftDotNet.API.PVP;
using WarcraftDotNet.API.Quest;
using WarcraftDotNet.API.RealmStatus;
using WarcraftDotNet.API.Recipe;
using WarcraftDotNet.API.Spell;
using WarcraftDotNet.API.Zone;

namespace WarcraftDotNet.Interfaces
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