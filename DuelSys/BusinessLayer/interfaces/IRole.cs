using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.interfaces
{
    public interface IRole
    {
        public string RoleName { get; set; }
        public bool CanAccessDesktopApp();

        public bool CanAccessTournamentCUD();

        public bool CanAccessMatchCUD();

        public bool CanAccessStaffCUD();

    }
}
