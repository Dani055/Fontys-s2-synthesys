using BusinessLayer.models;
using BusinessLayer.roles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuelSysUnitTests
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestStaffConstructor()
        {
            Staff s = new Staff(1, "stan", "123", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222);

            Assert.AreEqual(1, s.Id);
            Assert.AreEqual("stan", s.Username);
            Assert.AreEqual("123", s.Password);
            Assert.AreEqual("asd@asd.com", s.Email);
            Assert.AreEqual("123 avenue", s.Address);
            Assert.AreEqual("Staff", s.Firstname);
            Assert.AreEqual("stafferson", s.Lastname);
            Assert.AreEqual(typeof(StaffRole), s.Role.GetType());
            Assert.AreEqual(222, s.Salary);
        }

        [TestMethod]
        public void TestPlayerConstructor()
        {
            Player p = new Player(1, "player1", "123", "asd@asd.com", "123 avenue", "player", "playerson", "Player", 5, 3);

            Assert.AreEqual(1, p.Id);
            Assert.AreEqual("player1", p.Username);
            Assert.AreEqual("123", p.Password);
            Assert.AreEqual("asd@asd.com", p.Email);
            Assert.AreEqual("123 avenue", p.Address);
            Assert.AreEqual("player", p.Firstname);
            Assert.AreEqual("playerson", p.Lastname);
            Assert.AreEqual(typeof(PlayerRole), p.Role.GetType());
            Assert.AreEqual(5, p.Wongames);
            Assert.AreEqual(3, p.Lostgames);
        }
    }
}