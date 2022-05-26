using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer.interfaces;
using BusinessLayer.models;
using System;

namespace DuelSysUnitTests
{
    [TestClass]
    public class TourneyMatchTest
    {
        [TestMethod]
        public void TestMatchConstructor()
        {
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            TourneyMatch m = new TourneyMatch(1, 2, DateTime.MinValue, p1, 3, p2, 22, p2.Id);

            Assert.AreEqual(1, m.Id);
            Assert.AreEqual(2, m.TournamentId);
            Assert.AreEqual(DateTime.MinValue, m.DateHeld);
            Assert.AreEqual(p1, m.Player1);
            Assert.AreEqual(p2, m.Player2);
            Assert.AreEqual(3, m.Player1Points);
            Assert.AreEqual(22, m.Player2Points);
            Assert.AreEqual(p2.Id, m.WinnerId);
        }
    }
}
