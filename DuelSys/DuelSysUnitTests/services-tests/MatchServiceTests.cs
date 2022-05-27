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
    public class MatchServiceTests
    {
        [TestMethod]
        [ExpectedException(typeof(UnauthorizedAccessException))]
        public void ScheduleTournamentUnauthorized()
        {
            MockDALTournament tourneyDal = new MockDALTournament();
            TournamentValidator tourneyVal = new TournamentValidator();
            MockDALMatch matchDal = new MockDALMatch();
            MatchValidator matchVal = new MatchValidator();

            MatchService matchService = new MatchService(tourneyDal, matchDal, tourneyVal, matchVal);

            Player loggedUser = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);

            bool result = matchService.ScheduleTournament(4, loggedUser);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ScheduleTournamentUnsuccessful()
        {
            MockDALTournament tourneyDal = new MockDALTournament();
            TournamentValidator tourneyVal = new TournamentValidator();
            MockDALMatch matchDal = new MockDALMatch();
            MatchValidator matchVal = new MatchValidator();

            MatchService matchService = new MatchService(tourneyDal, matchDal, tourneyVal, matchVal);

            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            bool result = matchService.ScheduleTournament(1, loggedUser);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ScheduleTournamentAlreadyScheduled()
        {
            MockDALTournament tourneyDal = new MockDALTournament();
            TournamentValidator tourneyVal = new TournamentValidator();
            MockDALMatch matchDal = new MockDALMatch();
            MatchValidator matchVal = new MatchValidator();

            MatchService matchService = new MatchService(tourneyDal, matchDal, tourneyVal, matchVal);

            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            bool result = matchService.ScheduleTournament(2, loggedUser);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ScheduleTournamentTooLittlePlayers()
        {
            MockDALTournament tourneyDal = new MockDALTournament();
            TournamentValidator tourneyVal = new TournamentValidator();
            MockDALMatch matchDal = new MockDALMatch();
            MatchValidator matchVal = new MatchValidator();

            MatchService matchService = new MatchService(tourneyDal, matchDal, tourneyVal, matchVal);

            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            bool result = matchService.ScheduleTournament(5, loggedUser);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ScheduleTournamentSingleEliminationIncorrectPlayers()
        {
            MockDALTournament tourneyDal = new MockDALTournament();
            TournamentValidator tourneyVal = new TournamentValidator();
            MockDALMatch matchDal = new MockDALMatch();
            MatchValidator matchVal = new MatchValidator();

            MatchService matchService = new MatchService(tourneyDal, matchDal, tourneyVal, matchVal);

            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            bool result = matchService.ScheduleTournament(6, loggedUser);
        }

        [TestMethod]
        public void ScheduleTournamentSuccessful()
        {
            MockDALTournament tourneyDal = new MockDALTournament();
            TournamentValidator tourneyVal = new TournamentValidator();
            MockDALMatch matchDal = new MockDALMatch();
            MatchValidator matchVal = new MatchValidator();

            MatchService matchService = new MatchService(tourneyDal, matchDal, tourneyVal, matchVal);

            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            bool result = matchService.ScheduleTournament(4, loggedUser);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(UnauthorizedAccessException))]
        public void EnterMatchResultUnauthorized()
        {
            MockDALTournament tourneyDal = new MockDALTournament();
            TournamentValidator tourneyVal = new TournamentValidator();
            MockDALMatch matchDal = new MockDALMatch();
            MatchValidator matchVal = new MatchValidator();

            MatchService matchService = new MatchService(tourneyDal, matchDal, tourneyVal, matchVal);

            Player loggedUser = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            TourneyMatch match = new TourneyMatch();

            bool result = matchService.EnterMatchResult(match, loggedUser);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnterMatchResultForPendingGame()
        {
            MockDALTournament tourneyDal = new MockDALTournament();
            TournamentValidator tourneyVal = new TournamentValidator();
            MockDALMatch matchDal = new MockDALMatch();
            MatchValidator matchVal = new MatchValidator();

            MatchService matchService = new MatchService(tourneyDal, matchDal, tourneyVal, matchVal);

            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);

            TourneyMatch match = new TourneyMatch(1, 4, DateTime.Now.AddDays(1), p1, 0, p2, 0, 0);

            bool result = matchService.EnterMatchResult(match, loggedUser);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnterMatchResultForAlreadyPlayedGame()
        {
            MockDALTournament tourneyDal = new MockDALTournament();
            TournamentValidator tourneyVal = new TournamentValidator();
            MockDALMatch matchDal = new MockDALMatch();
            MatchValidator matchVal = new MatchValidator();

            MatchService matchService = new MatchService(tourneyDal, matchDal, tourneyVal, matchVal);

            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);

            TourneyMatch match = new TourneyMatch(1, 4, DateTime.Now, p1, 21, p2, 15, 1);

            bool result = matchService.EnterMatchResult(match, loggedUser);
        }

        [TestMethod]
        public void EnterMatchResultSuccessful()
        {
            MockDALTournament tourneyDal = new MockDALTournament();
            TournamentValidator tourneyVal = new TournamentValidator();
            MockDALMatch matchDal = new MockDALMatch();
            MatchValidator matchVal = new MatchValidator();

            MatchService matchService = new MatchService(tourneyDal, matchDal, tourneyVal, matchVal);

            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);
            Player p1 = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);
            Player p2 = new Player(2, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);

            TourneyMatch match = new TourneyMatch(1, 4, DateTime.Now, p1, 21, p2, 15, 0);

            bool result = matchService.EnterMatchResult(match, loggedUser);

            Assert.IsTrue(result);
        }
    }
}
