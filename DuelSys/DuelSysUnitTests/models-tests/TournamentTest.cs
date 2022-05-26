using BusinessLayer.models;
using BusinessLayer.tournament_systems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelSysUnitTests
{
    [TestClass]
    public class TournamentTest
    {
        [TestMethod]
        public void TestTournamentConstructor()
        {
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.MinValue, DateTime.MaxValue, 2, 4, "Eindhoven", "Round-robin", false);

            Assert.AreEqual(1, t.Id);
            Assert.AreEqual("Playoffs", t.Name);
            Assert.AreEqual("Badminton", t.SportName);
            Assert.AreEqual("desc", t.Description);
            Assert.AreEqual(DateTime.MinValue, t.StartDate);
            Assert.AreEqual(DateTime.MaxValue, t.EndDate);
            Assert.AreEqual(2, t.MinPlayers);
            Assert.AreEqual(4, t.MaxPlayers);
            Assert.AreEqual("Eindhoven", t.Location);
            Assert.AreEqual(typeof(Round_robin_system), t.System.GetType());
            Assert.IsFalse(t.HasStarted);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestTournamentWithInvalidSystem()
        {
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.MinValue, DateTime.MaxValue, 2, 4, "Eindhoven", "invalid_system", false);

            Assert.AreEqual(typeof(Round_robin_system), t.System.GetType());
        }
    }
}
