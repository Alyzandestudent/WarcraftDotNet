using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Net;
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
using WarcraftDotNet.Interfaces;

namespace WarcraftDotNet
{
    // ReSharper disable once InconsistentNaming
    public class WarcraftClient : IWarcraftClient
    {
        private readonly string _apiKey;
        private readonly Locale _locale;
        private readonly string _baseUrl;

        public WarcraftClient(string apiKey, Locale locale = null)
        {
            _apiKey = apiKey;
            _locale = locale ?? Locales.EN_US;
            _baseUrl = string.Format("{0}{1}.{2}{3}", Endpoints.Base.Protocol, _locale.UrlPrefix, Endpoints.Base.Url, Endpoints.Base.Wow);
        }


        #region Achievement
        public async Task<Achievement> GetAchievementAsync(int achievementId)
        {
            var path = $"{Endpoints.Achievement}/{achievementId}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Achievement>(request);

            return response;
        }
        #endregion


        #region Auction
        public async Task<List<AuctionData>> GetAuctionData(string realm)
        {
            var auctionData = new List<AuctionData>();
            var auctionFiles = await GetAuctionFileAsync(realm);

            foreach (var file in auctionFiles.FileList)
            {
                var data = await GetActionDataFromFile(file);

                auctionData.Add(data);
            }

            return auctionData;
        }

        private async Task<AuctionData> GetActionDataFromFile(File file)
        {
            var json = string.Empty;

            using (var client = new WebClient())
            {
                json = await client.DownloadStringTaskAsync(file.Url);
            }

            var auctionData = JsonConvert.DeserializeObject<AuctionData>(json);

            return auctionData;
        }

        private async Task<Files> GetAuctionFileAsync(string realm)
        {
            var path = $"{Endpoints.Auction}/{realm}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Files>(request);

            return response;
        }
        #endregion


        #region Boss
        public async Task<BossData> GetBossesAsync()
        {
            var path = $"{Endpoints.Boss}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<BossData>(request);

            return response;
        }

        public async Task<API.Boss.Boss> GetBossAsync(int bossId)
        {
            var path = $"{Endpoints.Boss}/{bossId}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<API.Boss.Boss>(request);

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
        public async Task<CharacterProfile> GetCharacterProfileAsync(string realm, string name, IEnumerable<string> fields)
        {
            var path = $"{Endpoints.Character}/{realm}/{name}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);
            request.AddQueryParameter("fields", string.Join(",", fields));

            var response = await ExecuteAsync<CharacterProfile>(request);

            return response;
        }
        #endregion


        #region Guild Profile
        public async Task<Guild> GetGuildAsync(string realm, string name, IEnumerable<string> fields)
        {
            var path = $"{Endpoints.Guild}/{realm}/{name}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);
            request.AddQueryParameter("fields", string.Join(",", fields));

            var response = await ExecuteAsync<Guild>(request);

            return response;
        }
        #endregion


        #region Item
        public async Task<Item> GetItemAsync(int itemId)
        {
            var path = $"{Endpoints.Item}/{itemId}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Item>(request);

            return response;
        }

        public async Task<ItemSet> GetItemSetAsync(int setId)
        {
            var path = $"{Endpoints.Item}/{setId}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<ItemSet>(request);

            return response;
        }
        #endregion


        #region Mount
        public async Task<Mounts> GetMountsAsync()
        {
            var path = $"{Endpoints.Mount}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Mounts>(request);

            return response;
        }
        #endregion


        #region Pet
        public async Task<Pets> GetPetsAsync()
        {
            var path = $"{Endpoints.Pet}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Pets>(request);

            return response;
        }

        public async Task<PetAbility> GetPetAbilityAsync(int abilityId)
        {
            var path = $"{Endpoints.Pet}/{Endpoints.Ability}/{abilityId}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<PetAbility>(request);

            return response;
        }

        public async Task<Species> GetPetSpeciesAsync(int speciesId)
        {
            var path = $"{Endpoints.Pet}/{Endpoints.Species}/{speciesId}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Species>(request);

            return response;
        }

        public async Task<Stats> GetPetSpeciesStatsAsync(int speciesId)
        {
            var path = $"{Endpoints.Pet}/{Endpoints.Stats}/{speciesId}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Stats>(request);

            return response;
        }
        #endregion


        #region PVP
        public async Task<Leaderboard> GetLeaderboardAsync(string bracket)
        {
            var path = $"{Endpoints.PVP}/{bracket}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Leaderboard>(request);

            return response;
        }
        #endregion


        #region Quest
        public async Task<Quest> GetQuestAsync(int questId)
        {
            var path = $"{Endpoints.Quest}/{questId}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Quest>(request);

            return response;
        }
        #endregion


        #region Realm Status
        public async Task<Realms> GetRealmStatusesAsync()
        {
            var path = $"{Endpoints.Realm}/{Endpoints.Status}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Realms>(request);

            return response;
        }
        #endregion


        #region Recipie
        public async Task<Recipe> GetRecipeAsync(int recipeId)
        {
            var path = $"{Endpoints.Recipe}/{recipeId}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Recipe>(request);

            return response;
        }
        #endregion


        #region Spell
        public async Task<Spell> GetSpellAsync(int spellId)
        {
            var path = $"{Endpoints.Spell}/{spellId}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Spell>(request);

            return response;
        }
        #endregion


        #region Zone
        public async Task<Zones> GetZonesAsync()
        {
            var path = $"{Endpoints.Zone}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Zones>(request);

            return response;
        }

        public async Task<Zone> GetZoneAsync(int zoneId)
        {
            var path = $"{Endpoints.Zone}/{zoneId}";
            var request = new RestRequest(path, Method.GET);
            request.AddQueryParameter("locale", _locale.Language);
            request.AddQueryParameter("apiKey", _apiKey);

            var response = await ExecuteAsync<Zone>(request);

            return response;
        }
        #endregion


        // TODO: Add Data Resources

        #region Private Methods
        private async Task<T> ExecuteAsync<T>(IRestRequest request)
        {
            var client = new RestClient(_baseUrl);
            var restResponse = await client.ExecuteTaskAsync(request);
            
            if (!restResponse.IsSuccessful)
            {
                // TODO: throw exception
            }

            var response = JsonConvert.DeserializeObject<T>(restResponse.Content);

            return response;
        }
        #endregion
    }
}
