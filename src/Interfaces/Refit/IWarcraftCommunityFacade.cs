using System.Threading.Tasks;
using Refit;
using WarcraftDotNet.Response.Achievement;

namespace WarcraftDotNet.Interfaces.Refit
{
    public interface IWarcraftCommunityFacade
    {
        #region Achievement API
        [Get("/achievement/{id}")]
        Task<Achievement> GetAchievementAsync(
            [Header("Authorization")] string token,
            [AliasAs("id")] int id,
            [Query] string locale = "en_US");
        #endregion
    }
}