using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.models
{
    public class Player : User
    {
        public int Wongames { get; set; }
        public int Lostgames { get; set; }

        public Player()
        {

        }
        public Player(int id, string username, string password, string email,string address, string firstname, string lastname, string role, int wongames, int lostgames) : base(id, username, password, email, address,firstname, lastname, role)
        {
            this.Wongames = wongames;
            this.Lostgames = lostgames;
        }
    }
}
