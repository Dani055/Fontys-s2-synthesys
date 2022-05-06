using BusinessLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.roles
{
    public class PlayerRole : IRole
    {
        public string RoleName { get; set; }
        public PlayerRole(string role)
        {
            RoleName = role;
        }
        public bool CanAccessDesktopApp()
        {
            return false;
        }
        public bool CanAccessTournamentCUD()
        {
            return false;
        }
        public bool CanAccessMatchCUD()
        {
            return false;
        }
        public bool CanAccessStaffCUD()
        {
            return false;
        }
    }
}
