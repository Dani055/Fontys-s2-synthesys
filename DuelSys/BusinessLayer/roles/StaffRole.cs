using BusinessLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.roles
{
    public class StaffRole : IRole
    {
        public string RoleName { get; set; }
        public StaffRole(string role)
        {
            RoleName = role;
        }
        public bool CanAccessDesktopApp()
        {
            return true;
        }
        public bool CanAccessTournamentCUD()
        {
            return true;
        }
        public bool CanAccessMatchCUD()
        {
            return true;
        }
        public bool CanAccessStaffCUD()
        {
            return true;
        }
    }
}
