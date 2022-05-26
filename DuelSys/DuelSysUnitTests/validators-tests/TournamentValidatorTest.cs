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
    public class TournamentValidatorTest
    {
        [TestMethod]
        public void TestTournamentBeginsInLessThanOneWeek()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(7), DateTime.Now.AddDays(1), 2, 4, "Eindhoven", "Round-robin", false);

            bool result = val.CheckIfTournamentBeginsInOneWeek(t);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestTournamentBeginsInMoreThanOneWeek()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.Now.AddDays(9), 2, 4, "Eindhoven", "Round-robin", false);

            bool result = val.CheckIfTournamentBeginsInOneWeek(t);

            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TournamentNameInvalid()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.Now.AddDays(9), 2, 4, "Eindhoven", "Round-robin", false);

            val.ValidateTournament(t);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TournamentSportInvalid()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "", "desc", DateTime.Now.AddDays(8), DateTime.Now.AddDays(9), 2, 4, "Eindhoven", "Round-robin", false);

            val.ValidateTournament(t);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TournamentDescriptionInvalid()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "", DateTime.Now.AddDays(8), DateTime.Now.AddDays(9), 2, 4, "Eindhoven", "Round-robin", false);

            val.ValidateTournament(t);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TournamentStartDateBiggerThanEnd()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.Now.AddDays(1), 2, 4, "Eindhoven", "Round-robin", false);

            val.ValidateTournament(t);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TournamentStartsInLessThanOneWeek()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(7), DateTime.Now.AddDays(10), 2, 4, "Eindhoven", "Round-robin", false);

            val.ValidateTournament(t);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TournamentInvalidPlayers()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.Now.AddDays(10), 1, 1, "Eindhoven", "Round-robin", false);

            val.ValidateTournament(t);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TournamentInvalidLocation()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.Now.AddDays(10), 2, 4, "", "Round-robin", false);

            val.ValidateTournament(t);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TournamentInvalidSystem()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.Now.AddDays(10), 2, 4, "Eindhoven", "Round-robin", false);
            t.System.SystemName = null;

            val.ValidateTournament(t);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SingleEliminationInvalidPlayers()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.Now.AddDays(10), 2, 4, "Eindhoven", "Single-elimination", false);

            val.ValidateTournament(t);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SingleEliminationTooManyGamesPerDay()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.Now.AddDays(10), 20, 40, "Eindhoven", "Single-elimination", false);

            val.ValidateTournament(t);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RoundRobinTooManyGamesPerDay()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.Now.AddDays(10), 20, 40, "Eindhoven", "Round-robin", false);

            val.ValidateTournament(t);
        }

        [TestMethod]
        public void ValidRoundRobinTournament()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.Now.AddDays(10), 2, 4, "Eindhoven", "Round-robin", false);

            bool result = val.ValidateTournament(t);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidSingleEliminationTournament()
        {
            TournamentValidator val = new TournamentValidator();
            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.Now.AddDays(10), 4, 4, "Eindhoven", "Single-elimination", false);

            bool result = val.ValidateTournament(t);
            Assert.IsTrue(result);
        }
    }
}
