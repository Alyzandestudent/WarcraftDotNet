using System.Threading.Tasks;
using WarcraftDotNet.Enums;
using WarcraftDotNet.Response.Achievement;

namespace WarcraftDotNet.Interfaces
{
    public interface IWarcraftClient
    {
        Task<Achievement> GetAchievementAsync(int id, RegionEnum? region);
    }
}