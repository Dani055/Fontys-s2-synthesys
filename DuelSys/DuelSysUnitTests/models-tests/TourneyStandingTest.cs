using BusinessLayer.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelSysUnitTests.models_tests
{
    [TestClass]
    public class TourneyStandingTest
    {
        [TestMethod]
        public void TestStandingConstructor()
        {
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            TourneyStanding s = new TourneyStanding(1, 2, p1, 3, 4, "Qualified", 5);

            Assert.AreEqual(1, s.Id);
            Assert.AreEqual(2, s.TournamentId);
            Assert.AreEqual(p1, s.Player);
            Assert.AreEqual(3, s.Wins);
            Assert.AreEqual(4, s.Losses);
            Assert.AreEqual("Qualified", s.Status);
            Assert.AreEqual(5, s.Place);
        }

        [TestMethod]
        public void TestStandingConstructorWithNullPlace()
        {
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            TourneyStanding s = new TourneyStanding(1, 2, p1, 3, 4, "Qualified", 0);

            Assert.AreEqual(1, s.Id);
            Assert.AreEqual(2, s.TournamentId);
            Assert.AreEqual(p1, s.Player);
            Assert.AreEqual(3, s.Wins);
            Assert.AreEqual(4, s.Losses);
            Assert.AreEqual("Qualified", s.Status);
            Assert.AreEqual(null, s.Place);
        }
    }
}
