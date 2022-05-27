using BusinessLayer.models;
using BusinessLayer.validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelSysUnitTests.validators_tests
{
    [TestClass]

    public class MatchValidatorTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MatchUndeterminedPlayers()
        {
            MatchValidator val = new MatchValidator();
            TourneyMatch match = new TourneyMatch(1, 1, DateTime.MinValue, null, 0, new Player(), 0, 0);

            val.DetermineWinner(match);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MatchPlayersHaveTooManyPoints()
        {
            MatchValidator val = new MatchValidator();
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            TourneyMatch match = new TourneyMatch(1, 1, DateTime.MinValue, p1, 35, p2, 29, 0);

            val.DetermineWinner(match);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MatchPlayersHaveInsufficientPoints()
        {
            MatchValidator val = new MatchValidator();
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            TourneyMatch match = new TourneyMatch(1, 1, DateTime.MinValue, p1, 5, p2, 3, 0);

            val.DetermineWinner(match);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MatchPlayerLeadIsInsufficient()
        {
            MatchValidator val = new MatchValidator();
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            TourneyMatch match = new TourneyMatch(1, 1, DateTime.MinValue, p1, 23, p2, 24, 0);

            val.DetermineWinner(match);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MatchPlayersAreTied()
        {
            MatchValidator val = new MatchValidator();
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            TourneyMatch match = new TourneyMatch(1, 1, DateTime.MinValue, p1, 29, p2, 29, 0);

            val.DetermineWinner(match);
        }

        [TestMethod]
        public void TestWinnerNormal()
        {
            MatchValidator val = new MatchValidator();
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            TourneyMatch match = new TourneyMatch(1, 1, DateTime.MinValue, p1, 21, p2, 5, 0);

            int result = val.DetermineWinner(match);

            Assert.AreEqual(p1.Id, result);
        }

        [TestMethod]
        public void TestWinnerOver20Points()
        {
            MatchValidator val = new MatchValidator();
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            TourneyMatch match = new TourneyMatch(1, 1, DateTime.MinValue, p1, 23, p2, 21, 0);

            int result = val.DetermineWinner(match);

            Assert.AreEqual(p1.Id, result);
        }

        [TestMethod]
        public void TestWinnerAfterTie()
        {
            MatchValidator val = new MatchValidator();
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            TourneyMatch match = new TourneyMatch(1, 1, DateTime.MinValue, p1, 29, p2, 30, 0);

            int result = val.DetermineWinner(match);

            Assert.AreEqual(p2.Id, result);
        }
    }
}
