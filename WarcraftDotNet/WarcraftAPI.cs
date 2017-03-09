using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
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

namespace WarcraftDotNet
{
    // ReSharper disable once InconsistentNaming
    public class WarcraftAPI
    {
        private static string _apiKey;
        private static Locale _locale;
        private static string _baseUrl;

        public WarcraftAPI(string apiKey, Locale locale = null)
        {
            _apiKey = apiKey;
            _locale = locale ?? Locales.EN_US;
            _baseUrl = string.Format("{0}{1}.{2}{3}", Endpoints.Base.Protocol, _locale.UrlPrefix, Endpoints.Base.Url, Endpoints.Base.Wow);
        }


        #region Achievement
        public async Task<Achievement> GetAchievement(int achievementId)
        {
            var url = _baseUrl + Endpoints.Achievement;
            url = url.AppendPathSegment(achievementId);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Achievement>();

            return response;
        }
        #endregion


        #region Auction
        public async Task<List<AuctionData>> GetAuctionData(string realm)
        {
            var auctionData = new List<AuctionData>();
            var auctionFiles = await GetAuctionFile(realm);

            foreach (var file in auctionFiles.FileList)
            {
                var data = await GetActionDataFromFile(file);

                auctionData.Add(data);
            }

            return auctionData;
        }

        private static async Task<AuctionData> GetActionDataFromFile(File file)
        {
            var json = await file.Url.GetStringAsync();
            var auctionData = JsonConvert.DeserializeObject<AuctionData>(json);

            return auctionData;
        }

        private static async Task<Files> GetAuctionFile(string realm)
        {
            var url = _baseUrl + Endpoints.Auction;
            url = url.AppendPathSegment(realm);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Files>();

            return response;
        }
        #endregion


        #region Boss
        public async Task<BossData> GetBosses()
        {
            var url = _baseUrl + Endpoints.Boss + "/";

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<BossData>();

            return response;
        }

        public async Task<API.Boss.Boss> GetBoss(int bossId)
        {
            var url = _baseUrl + Endpoints.Boss;
            url = url.AppendPathSegment(bossId);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<API.Boss.Boss>();

            return response;
        }
        #endregion

        // TODO: Add Challenge Mode
        #region Challenge Mode
        #endregion


        #region Character Profile
        // TODO: Add Appearance
        // TODO: Add Feed
        // TODO: Add Guild
        // TODO: Add Hunter Pets
        // TODO: Add Items
        // TODO: Add Mounts
        // TODO: Add Pets
        // TODO: Add Pet Slots
        // TODO: Add Professions
        // TODO: Add PVP
        // TODO: Add Quests
        // TODO: Add Reputation
        // TODO: Add Statistics
        // TODO: Add Stats
        // TODO: Add Talents
        // TODO: Add Titles
        // TODO: Add Audit
        public async Task<CharacterProfile> GetCharacterProfile(string realm, string name, List<string> fields)
        {
            var url = _baseUrl + Endpoints.Character;
            url = url.AppendPathSegment(realm);
            url = url.AppendPathSegment(name);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey,
                fields = string.Join(",", fields)
            });

            var response = await url.GetJsonAsync<CharacterProfile>();

            return response;
        }
        #endregion


        #region Guild Profile
        public async Task<Guild> GetGuild(string realm, string name, List<string> fields)
        {
            var url = _baseUrl + Endpoints.Guild;
            url = url.AppendPathSegment(realm);
            url = url.AppendPathSegment(name);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey,
                fields = string.Join(",", fields)
            });

            var response = await url.GetJsonAsync<Guild>();

            return response;
        }
        #endregion


        #region Item
        public async Task<Item> GetItem(int itemId)
        {
            var url = _baseUrl + Endpoints.Item;
            url = url.AppendPathSegment(itemId);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Item>();

            return response;
        }

        public async Task<ItemSet> GetItemSet(int setId)
        {
            var url = _baseUrl + Endpoints.Item + Endpoints.Set;
            url = url.AppendPathSegment(setId);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<ItemSet>();

            return response;
        }
        #endregion


        #region Mount
        public async Task<Mounts> GetMounts()
        {
            var url = _baseUrl + Endpoints.Mount + "/";

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Mounts>();

            return response;
        }
        #endregion


        #region Pet
        public async Task<Pets> GetPets()
        {
            var url = _baseUrl + Endpoints.Pet + "/";

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Pets>();

            return response;
        }

        public async Task<PetAbility> GetPetAbility(int abilityId)
        {
            var url = _baseUrl + Endpoints.Pet + Endpoints.Ability;
            url = url.AppendPathSegment(abilityId);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<PetAbility>();

            return response;
        }

        public async Task<Species> GetPetSpecies(int speciesId)
        {
            var url = _baseUrl + Endpoints.Pet + Endpoints.Species;
            url = url.AppendPathSegment(speciesId);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Species>();

            return response;
        }

        public async Task<Stats> GetPetSpeciesStats(int speciesId)
        {
            var url = _baseUrl + Endpoints.Pet + Endpoints.Stats;
            url = url.AppendPathSegment(speciesId);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Stats>();

            return response;
        }
        #endregion


        #region PVP
        public async Task<Leaderboard> GetLeaderboard(string bracket)
        {
            var url = _baseUrl + Endpoints.PVP;
            url = url.AppendPathSegment(bracket);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Leaderboard>();

            return response;
        }
        #endregion


        #region Quest
        public async Task<Quest> GetQuest(int questId)
        {
            var url = _baseUrl + Endpoints.Quest;
            url = url.AppendPathSegment(questId);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Quest>();

            return response;
        }
        #endregion


        #region Realm Status
        public async Task<Realms> GetRealmStatuses()
        {
            var url = _baseUrl + Endpoints.Realm + Endpoints.Status;

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Realms>();

            return response;
        }
        #endregion


        #region Recipie
        public async Task<Recipe> GetRecipe(int recipeId)
        {
            var url = _baseUrl + Endpoints.Recipe;
            url = url.AppendPathSegment(recipeId);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Recipe>();

            return response;
        }
        #endregion


        #region Spell
        public async Task<Spell> GetSpell(int spellId)
        {
            var url = _baseUrl + Endpoints.Spell;
            url = url.AppendPathSegment(spellId);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Spell>();

            return response;
        }
        #endregion


        #region Zone
        public async Task<Zones> GetZones()
        {
            var url = _baseUrl + Endpoints.Zone + "/";

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Zones>();

            return response;
        }

        public async Task<Zone> GetZone(int zoneId)
        {
            var url = _baseUrl + Endpoints.Zone;
            url = url.AppendPathSegment(zoneId);

            url = url.SetQueryParams(new
            {
                locale = _locale.Language,
                apiKey = _apiKey
            });

            var response = await url.GetJsonAsync<Zone>();

            return response;
        }
        #endregion


        // TODO: Add Data Resources
    }
}
