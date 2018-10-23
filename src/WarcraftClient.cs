using Refit;
using System.Threading.Tasks;
using WarcraftDotNet.Enums;
using WarcraftDotNet.Interfaces;
using WarcraftDotNet.Interfaces.Refit;
using WarcraftDotNet.Response.Achievement;

namespace WarcraftDotNet
{
    public class WarcraftClient : BaseClient, IWarcraftClient
    {
        public WarcraftClient(string clientId, string secret, RegionEnum region = RegionEnum.US) : base(clientId, secret, region)
        {
        }

        public async Task<Achievement> GetAchievementAsync(int id, RegionEnum? region)
        {
            if (region == null)
            {
                region = this.DefaultRegion;
            }

            var url = this.GetCommunityUrl(GameEnum.WoW, region);
            var token = this.GetAccessToken(region);

            var response = await RestService.For<IWarcraftCommunityFacade>(url).GetAchievementAsync($"Bearer {token.AccessToken}", id);

            return response;
        }
    }
}