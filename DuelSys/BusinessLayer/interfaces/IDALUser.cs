
using BusinessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.interfaces
{
    public interface IDALUser
    {
        public User Login(string username);
        public bool RegisterStaff(Staff staff);

        public bool RegisterPlayer(Player player);
    }
}
