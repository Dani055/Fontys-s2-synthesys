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
    public class TourneySystemTest
    {
        [TestMethod]
        public void TestRoundRobinConstructor()
        {
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.MinValue, DateTime.MaxValue, 2, 4, "Eindhoven", "Round-robin", false);
            Round_robin_system s = new Round_robin_system(new Tournament(), "syst");

            Assert.AreEqual(s.SystemName, "syst");
        }

        [TestMethod]
        public void TestCalculateRoundRobinGamesPerDay()
        {
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now, DateTime.Now.AddDays(1), 2, 4, "Eindhoven", "Round-robin", false);
            List<TourneyStanding> registered = new List<TourneyStanding>();
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            Player p3 = new Player(3, "player3", "123", "asd@asd.com", "123 avenue", "player", "three", "Player", 5, 3);
            Player p4 = new Player(4, "player4", "123", "asd@asd.com", "123 avenue", "player", "four", "Player", 5, 3);
            TourneyStanding s1 = new TourneyStanding(3, 1, p1, 0, 0, "Qualified", 0);
            TourneyStanding s2 = new TourneyStanding(4, 1, p2, 0, 0, "Qualified", 0);
            TourneyStanding s3 = new TourneyStanding(5, 1, p3, 0, 0, "Qualified", 0);
            TourneyStanding s4 = new TourneyStanding(6, 1, p4, 0, 0, "Qualified", 0);

            registered.Add(s1);
            registered.Add(s2);
            registered.Add(s3);
            registered.Add(s4);

            int games = t.System.CalculateGamesPerDay(registered);

            Assert.AreEqual(3, games);
        }

        [TestMethod]
        public void TestGenerateRoundRobinGames()
        {
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now, DateTime.Now.AddDays(1), 2, 4, "Eindhoven", "Round-robin", false);
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            Player p3 = new Player(3, "player3", "123", "asd@asd.com", "123 avenue", "player", "three", "Player", 5, 3);
            Player p4 = new Player(4, "player4", "123", "asd@asd.com", "123 avenue", "player", "four", "Player", 5, 3);
            TourneyStanding s1 = new TourneyStanding(3, 1, p1, 0, 0, "Qualified", 0);
            TourneyStanding s2 = new TourneyStanding(4, 1, p2, 0, 0, "Qualified", 0);
            TourneyStanding s3 = new TourneyStanding(5, 1, p3, 0, 0, "Qualified", 0);
            TourneyStanding s4 = new TourneyStanding(6, 1, p4, 0, 0, "Qualified", 0);
            t.standings = new List<TourneyStanding>();
            t.standings.Add(s1);
            t.standings.Add(s2);
            t.standings.Add(s3);
            t.standings.Add(s4);

            List<TourneyMatch> matches = t.System.GenerateTournamentMatches();

            Assert.AreEqual(6, matches.Count);
            //Match 1
            Assert.AreEqual(p1, matches[0].Player1);
            Assert.AreEqual(p2, matches[0].Player2);

            //Match 2
            Assert.AreEqual(p1, matches[1].Player1);
            Assert.AreEqual(p3, matches[1].Player2);

            //Match 3
            Assert.AreEqual(p1, matches[2].Player1);
            Assert.AreEqual(p4, matches[2].Player2);

            //Match 4
            Assert.AreEqual(p2, matches[3].Player1);
            Assert.AreEqual(p3, matches[3].Player2);

            //Match 5
            Assert.AreEqual(p2, matches[4].Player1);
            Assert.AreEqual(p4, matches[4].Player2);

            //Match 6
            Assert.AreEqual(p3, matches[5].Player1);
            Assert.AreEqual(p4, matches[5].Player2);
        }

        [TestMethod]
        public void TestEliminationConstructor()
        {
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.MinValue, DateTime.MaxValue, 2, 4, "Eindhoven", "Single-elimination", false);
            Single_elimination_system s = new Single_elimination_system(new Tournament(), "syst");

            Assert.AreEqual(s.SystemName, "syst");
        }

        [TestMethod]
        public void TestCalculateEliminationGamesPerDay()
        {
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now, DateTime.Now.AddDays(1), 2, 4, "Eindhoven", "Single-elimination", false);
            List<TourneyStanding> registered = new List<TourneyStanding>();
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            Player p3 = new Player(3, "player3", "123", "asd@asd.com", "123 avenue", "player", "three", "Player", 5, 3);
            Player p4 = new Player(4, "player4", "123", "asd@asd.com", "123 avenue", "player", "four", "Player", 5, 3);
            TourneyStanding s1 = new TourneyStanding(3, 1, p1, 0, 0, "Qualified", 0);
            TourneyStanding s2 = new TourneyStanding(4, 1, p2, 0, 0, "Qualified", 0);
            TourneyStanding s3 = new TourneyStanding(5, 1, p3, 0, 0, "Qualified", 0);
            TourneyStanding s4 = new TourneyStanding(6, 1, p4, 0, 0, "Qualified", 0);

            registered.Add(s1);
            registered.Add(s2);
            registered.Add(s3);
            registered.Add(s4);

            int games = t.System.CalculateGamesPerDay(registered);

            Assert.AreEqual(2, games);
        }

        [TestMethod]
        public void TestGenerateEliminationGames()
        {
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now, DateTime.Now.AddDays(1), 2, 4, "Eindhoven", "Single-elimination", false);
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            Player p3 = new Player(3, "player3", "123", "asd@asd.com", "123 avenue", "player", "three", "Player", 5, 3);
            Player p4 = new Player(4, "player4", "123", "asd@asd.com", "123 avenue", "player", "four", "Player", 5, 3);
            TourneyStanding s1 = new TourneyStanding(3, 1, p1, 0, 0, "Qualified", 0);
            TourneyStanding s2 = new TourneyStanding(4, 1, p2, 0, 0, "Qualified", 0);
            TourneyStanding s3 = new TourneyStanding(5, 1, p3, 0, 0, "Qualified", 0);
            TourneyStanding s4 = new TourneyStanding(6, 1, p4, 0, 0, "Qualified", 0);
            t.standings = new List<TourneyStanding>();
            t.standings.Add(s1);
            t.standings.Add(s2);
            t.standings.Add(s3);
            t.standings.Add(s4);

            List<TourneyMatch> matches = t.System.GenerateTournamentMatches();

            Assert.AreEqual(3, matches.Count);
            //Match 1
            Assert.AreEqual(p1, matches[0].Player1);
            Assert.AreEqual(p2, matches[0].Player2);

            //Match 2
            Assert.AreEqual(p3, matches[1].Player1);
            Assert.AreEqual(p4, matches[1].Player2);

            //Match 3
            Assert.AreEqual(0, matches[2].Player1.Id);
            Assert.AreEqual(0, matches[2].Player2.Id);

        }
    }
}
