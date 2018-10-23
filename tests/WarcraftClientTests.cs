using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarcraftDotNet.Enums;
using WarcraftDotNet.Interfaces;

namespace WarcraftDotNet.Tests
{
    [TestClass]
    public class WarcraftClientTests
    {
        private readonly IWarcraftClient warcraftClient;

        public WarcraftClientTests()
        {
            var clientId = Environment.GetEnvironmentVariable("BlizzardClientId");
            var secret = Environment.GetEnvironmentVariable("BlizzardSecret");
            var region = RegionEnum.US;

            warcraftClient = new WarcraftClient(clientId, secret, region);
        }

        [TestMethod]
        public async Task GetAchievementAsync_Test()
        {
            const int achievementId = 5179;
            const string title = "Alliance Slayer";

            var response = await warcraftClient.GetAchievementAsync(achievementId, RegionEnum.US);

            Assert.AreEqual(title, response.Title);
        }
    }
}