using BusinessLayer.interfaces;
using BusinessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.mock
{
    public class MockDALUser : IDALUser
    {
        private List<User> users = new List<User>()
        {
            new Player(1, "player1", "$MYHASH$V1$10000$vFgylONJFQ6dGLD71J/NxOzF5hRYYOdY9agCHXs7FYUxhllq", "asd@asd.com", "123 avenue", "player", "one", "Player", 5, 3),
            new Staff(2, "stan", "$MYHASH$V1$10000$VGQCOImX8P7uahggzFc6MHOiRNnA+r0R/4trYnsYxFRezxSV", "asd@asd.com", "123 avenue", "Staff", "stafferson", "Staff", 222)

        };
        public User Login(string username)
        {
            return users.FirstOrDefault(x => x.Username == username);
        }

        public bool RegisterPlayer(Player player)
        {
            users.Add(player);
            return true;
        }

        public bool RegisterStaff(Staff staff)
        {
            users.Add(staff);
            return true;
        }
    }
}
