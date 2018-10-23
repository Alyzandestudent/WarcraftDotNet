using System;
using System.Text;
using RestSharp;
using WarcraftDotNet.Enums;
using WarcraftDotNet.Response.OAuth;

namespace WarcraftDotNet
{
    public abstract class BaseClient
    {
        protected readonly string ClientId;
        protected readonly string Secret;
        protected readonly RegionEnum DefaultRegion;

        protected BaseClient(string clientId, string secret, RegionEnum defaultRegion = RegionEnum.US)
        {
            this.ClientId = clientId;
            this.Secret = secret;
            this.DefaultRegion = defaultRegion;
        }

        protected string GetCommunityUrl(GameEnum game, RegionEnum? region)
        {
            if (region == null)
            {
                region = this.DefaultRegion;
            }

            var url = $"https://{region.Value.ToString().ToLower()}.api.blizzard.com/{game.ToString().ToLower()}";

            return url;
        }

        protected Token GetAccessToken(RegionEnum? region)
        {
            if (region == null)
            {
                region = this.DefaultRegion;
            }

            var url = $"https://{region.Value.ToString().ToLower()}.battle.net";

            var restRequest = new RestRequest("/oauth/token", Method.POST);
            restRequest.AddHeader("cache-control", "no-cache");
            restRequest.AddHeader("content-type", "application/x-www-form-urlencoded");
            restRequest.AddParameter("application/x-www-form-urlencoded", 
                $"grant_type=client_credentials&client_id={this.ClientId}&client_secret={this.Secret}", ParameterType.RequestBody);

            var client = new RestClient(url);
            var response = client.Execute<Token>(restRequest);

            return response.Data;
        }
    }
}