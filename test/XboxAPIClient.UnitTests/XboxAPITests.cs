using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using XboxAPIClient.Models.V2;

namespace XboxAPIClient.UnitTests
{
    [TestClass]
    public class XboxApiTests
    {
        private const string testApiKey = "<YOUR_API_KEY_HERE>";

        private const string testGamertag = "P3";
        private const string testXuid = "2706851026034373";
        private const string xbox360TitleId = "1463158738";
        private const string xboxOneTitleId = "983730484";

        private XboxAPI api;

        [TestInitialize]
        public void TestSetup()
        {
            api = new XboxAPI(testApiKey);
        }

        [TestMethod]
        public void AccountProfile_ReturnsResponse()
        {
            AccountProfile response = api.AccountProfile().GetAwaiter().GetResult();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void AccountXuid_ReturnsResponse()
        {
            AccountXuid response = api.AccountXuid().GetAwaiter().GetResult();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void Gamercard_ReturnsResponse()
        {
            Gamercard response = api.Gamercard(testXuid).GetAwaiter().GetResult();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GamertagXuid_ReturnsResponse()
        {
            GamertagXuid response = api.GamertagXuid(testGamertag).GetAwaiter().GetResult();
            Assert.IsNotNull(response);
            Assert.AreEqual(testXuid, response.Xuid);
        }

        [TestMethod]
        public void GameStats_GivenXbox360Game_ReturnsResponse()
        {
            GameStats response = api.GameStats(testXuid, xbox360TitleId).GetAwaiter().GetResult();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GameStats_GivenXboxOneGame_ReturnsResponse()
        {
            GameStats response = api.GameStats(testXuid, xboxOneTitleId).GetAwaiter().GetResult();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void Presence_ReturnsResponse()
        {
            Presence response = api.Presence(testXuid).GetAwaiter().GetResult();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void Profile_ReturnsResponse()
        {
            Profile response = api.Profile(testXuid).GetAwaiter().GetResult();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void Xbox360Games_ReturnsResponse()
        {
            Xbox360Games response = api.Xbox360Games(testXuid).GetAwaiter().GetResult();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void Xbox360GameAchievements_ReturnsResponse()
        {
            List<Xbox360GameAchievement> response = api.Xbox360GameAchievements(xbox360TitleId, testXuid).GetAwaiter()
                .GetResult();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void XboxOneGameAchievements_ReturnsResponse()
        {
            List<XboxOneGameAchievement> response = api.XboxOneGameAchievements(xboxOneTitleId, testXuid).GetAwaiter()
                .GetResult();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void XboxOneGames_ReturnsResponse()
        {
            XboxOneGames response = api.XboxOneGames(testXuid).GetAwaiter().GetResult();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void XuidGamertag_ReturnsResponse()
        {
            XuidGamertag response = api.XuidGamertag(testXuid).GetAwaiter().GetResult();
            Assert.IsNotNull(response);
            Assert.AreEqual(testGamertag, response.Gamertag);
        }
    }
}