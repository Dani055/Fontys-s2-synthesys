using BusinessLayer.roles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelSysUnitTests
{
    [TestClass]
    public class RolesTest
    {
        [TestMethod]
        public void TestPlayerRole()
        {
            PlayerRole r = new PlayerRole("Player");

            Assert.AreEqual("Player", r.RoleName);
            Assert.IsFalse(r.CanAccessDesktopApp());
            Assert.IsFalse(r.CanAccessStaffCUD());
            Assert.IsFalse(r.CanAccessMatchCUD());
            Assert.IsFalse(r.CanAccessTournamentCUD());
        }

        [TestMethod]
        public void TestStaffRole()
        {
            StaffRole r = new StaffRole("Staff");

            Assert.AreEqual("Staff", r.RoleName);
            Assert.IsTrue(r.CanAccessDesktopApp());
            Assert.IsTrue(r.CanAccessStaffCUD());
            Assert.IsTrue(r.CanAccessMatchCUD());
            Assert.IsTrue(r.CanAccessTournamentCUD());
        }
    }
}
