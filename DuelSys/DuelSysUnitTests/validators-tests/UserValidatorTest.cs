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
    public class UserValidatorTest
    {
        [TestMethod]
        [ExpectedException (typeof(ArgumentException))]
        public void InvalidStaffUsername()
        {
            UserValidator val = new UserValidator();
            Staff s = new Staff(1, "", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            val.ValidateStaff(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidStaffPassword()
        {
            UserValidator val = new UserValidator();
            Staff s = new Staff(1, "stan", "12", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            val.ValidateStaff(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidStaffFirstname()
        {
            UserValidator val = new UserValidator();
            Staff s = new Staff(1, "stan", "123", "asd@asd.com", "123 avenue", "", "stafferson", "Staff", 222);

            val.ValidateStaff(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidStafflasttname()
        {
            UserValidator val = new UserValidator();
            Staff s = new Staff(1, "stan", "123", "asd@asd.com", "123 avenue", "Staff", "", "Staff", 222);

            val.ValidateStaff(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidStaffRole()
        {
            UserValidator val = new UserValidator();
            Staff s = new Staff(1, "stan", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);
            s.Role.RoleName = null;

            val.ValidateStaff(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidStaffEmail()
        {
            UserValidator val = new UserValidator();
            Staff s = new Staff(1, "stan", "123", "asd@a", "123 avenue", "Staff", "stafferson", "Staff", 222);

            val.ValidateStaff(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidStaffSalary()
        {
            UserValidator val = new UserValidator();
            Staff s = new Staff(1, "stan", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", -5);

            val.ValidateStaff(s);
        }

        [TestMethod]
        public void ValidStaff()
        {
            UserValidator val = new UserValidator();
            Staff s = new Staff(1, "stan", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 2);

            bool result = val.ValidateStaff(s);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidPlayerUsername()
        {
            UserValidator val = new UserValidator();
            Player p = new Player(1, "", "123", "asd@asd.com", "123 avenue", "player", "playerson", "Player", 5, 3);

            val.ValidatePlayer(p);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidPlayerPassword()
        {
            UserValidator val = new UserValidator();
            Player p = new Player(1, "player1", "1", "asd@asd.com", "123 avenue", "player", "playerson", "Player", 5, 3);

            val.ValidatePlayer(p);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidPlayerFirstname()
        {
            UserValidator val = new UserValidator();
            Player p = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "", "playerson", "Player", 5, 3);

            val.ValidatePlayer(p);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidPlayerLastname()
        {
            UserValidator val = new UserValidator();
            Player p = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "", "Player", 5, 3);

            val.ValidatePlayer(p);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidPlayerRole()
        {
            UserValidator val = new UserValidator();
            Player p = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "playerson", "Player", 5, 3);
            p.Role.RoleName = null;

            val.ValidatePlayer(p);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidPlayerEmail()
        {
            UserValidator val = new UserValidator();
            Player p = new Player(1, "player1", "123", "as", "123 avenue", "player", "playerson", "Player", 5, 3);

            val.ValidatePlayer(p);
        }
        [TestMethod]
        public void ValidPlayer()
        {
            UserValidator val = new UserValidator();
            Player p = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "playerson", "Player", 5, 3);

            bool result = val.ValidatePlayer(p);

            Assert.IsTrue(result);
        }
    }
}
