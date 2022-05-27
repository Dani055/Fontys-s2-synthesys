using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.models;
using BusinessLayer.services;
using BusinessLayer.validators;
using DAL.mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuelSysUnitTests.services_tests
{
    [TestClass]
    public class TournamentServiceTests
    {
        [TestMethod]
        [ExpectedException(typeof(UnauthorizedAccessException))]
        public void CreateTournamentUnauthorized()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            Tournament t = new Tournament();
            Player loggedUser = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);

            bool result = tourneyService.CreateTournament(t, loggedUser);
        }

        //Not testing input validation because it is tested separately in the validators test
        [TestMethod]
        public void CreateTournamentSuccessful()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.MaxValue, 2, 4, "Eindhoven", "Round-robin", false);
            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            bool result = tourneyService.CreateTournament(t, loggedUser);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(UnauthorizedAccessException))]
        public void EditTournamentUnauthorized()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            Tournament t = new Tournament();
            Player loggedUser = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);

            bool result = tourneyService.EditTournament(t, loggedUser);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEditTournamentBeginsTooSoon()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            Tournament t = new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(2), DateTime.MaxValue, 2, 4, "Eindhoven", "Round-robin", false);
            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            bool result = tourneyService.EditTournament(t, loggedUser);
        }

        [TestMethod]
        public void EditTournamentSuccessful()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            Tournament t = new Tournament(1, "Xd", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.MaxValue, 4, 4, "Eindhoven", "Single-elimination", false);
            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            bool result = tourneyService.EditTournament(t, loggedUser);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(UnauthorizedAccessException))]
        public void DeleteTournamentUnauthorized()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            Player loggedUser = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);

            bool result = tourneyService.DeleteTournament(1, loggedUser);
        }

        [TestMethod]
        public void DeleteTournamentSuccessful()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            bool result = tourneyService.DeleteTournament(1, loggedUser);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetTournamentByIdSuccessful()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            Tournament t = tourneyService.GetTournamentById(1);

            Assert.IsNotNull(t);
        }

        [TestMethod]
        public void GetTournamentByIncorrectId()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            Tournament t = tourneyService.GetTournamentById(1);

            Assert.IsNotNull(t);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RegisterForTournamentThatBeginsTooSoon()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            bool result = tourneyService.RegisterPlayerForTournament(2, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RegisterForTournamentMoreThanOnce()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            tourneyService.RegisterPlayerForTournament(1, 1);
        }

        [TestMethod]
        public void RegisterForTournamentSuccessful()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            bool result = tourneyService.RegisterPlayerForTournament(1, 2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TryDeregisterWhenNotRegistered()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            tourneyService.DeregisterPlayerForTournament(1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TryDeregisterWhenTournamentBeginsTooSoon()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            tourneyService.DeregisterPlayerForTournament(2, 1);
        }

        [TestMethod]
        public void DeregisterFromTournamentSuccessful()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            tourneyService.DeregisterPlayerForTournament(1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(UnauthorizedAccessException))]
        public void ConcludeTournamentUnauthorized()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            Player loggedUser = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);

            bool result = tourneyService.ConcludeTournamentAndRankPlayers(1, loggedUser);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ConcludeNotEndedTournament()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            bool result = tourneyService.ConcludeTournamentAndRankPlayers(1, loggedUser);
        }

        [TestMethod]
        public void ConcludeTournamentSuccessful()
        {
            MockDALTournament dal = new MockDALTournament();
            TournamentValidator val = new TournamentValidator();
            TournamentService tourneyService = new TournamentService(dal, val);

            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            bool result = tourneyService.ConcludeTournamentAndRankPlayers(3, loggedUser);

            Assert.IsTrue(result);
        }
    }
}
