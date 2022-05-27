using BusinessLayer.models;
using BusinessLayer.services;
using BusinessLayer.validators;
using DAL.mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelSysUnitTests.services_tests
{
    [TestClass]
    public class UserServiceTest
    {

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestLoginUsernameIncorrect()
        {
            MockDALUser dal = new MockDALUser();
            UserValidator val = new UserValidator();
            UserService userService = new UserService(dal, val);

            string username = "asd";
            User user = userService.Login(username, "123");

        }

        [TestMethod]
        [ExpectedException(typeof(UnauthorizedAccessException))]
        public void TestLoginPasswordIncorrect()
        {
            MockDALUser dal = new MockDALUser();
            UserValidator val = new UserValidator();
            UserService userService = new UserService(dal, val);

            string username = "player1";
            User user = userService.Login(username, "asd");

        }

        [TestMethod]
        public void TestLoginCorrect()
        {
            MockDALUser dal = new MockDALUser();
            UserValidator val = new UserValidator();
            UserService userService = new UserService(dal, val);

            string username = "player1";
            User user = userService.Login(username, "123");

            Assert.AreEqual(username, user.Username);
            Assert.AreEqual(1, user.Id);
        }

        //Not testing input validation because it is tested separately in the validators test
        [TestMethod]
        [ExpectedException(typeof(UnauthorizedAccessException))]
        public void RegisterStaffUnauthorized()
        {
            MockDALUser dal = new MockDALUser();
            UserValidator val = new UserValidator();
            UserService userService = new UserService(dal, val);

            Staff userToRegister = new Staff(3, "jrdn", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);
            Player loggedUser = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3);

            bool result = userService.Register(userToRegister, loggedUser);
        }

        [TestMethod]
        public void RegisterStaffSuccessful()
        {
            MockDALUser dal = new MockDALUser();
            UserValidator val = new UserValidator();
            UserService userService = new UserService(dal, val);

            Staff userToRegister = new Staff(3, "jrdn", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);
            Staff loggedUser = new Staff(4, "krl", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            bool result = userService.Register(userToRegister, loggedUser);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RegisterPlayerSuccessful()
        {
            MockDALUser dal = new MockDALUser();
            UserValidator val = new UserValidator();
            UserService userService = new UserService(dal, val);

            Player userToRegister = new Player(6, "player2", "123", "asd@asd.com", "123 avenue", "player", "two", "Player", 5, 3);
            Staff loggedUser = null;

            bool result = userService.Register(userToRegister, loggedUser);

            Assert.IsTrue(result);
        }
    }
}
