using BusinessLayer.interfaces;
using BusinessLayer.roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public IRole Role { get; set; }

        public User()
        {

        }
        public User(int id, string username, string password, string email,string address, string firstname, string lastname, string role)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            Address = address;
            Firstname = firstname;
            Lastname = lastname;
            Role = Activator.CreateInstance(Type.GetType("BusinessLayer.roles." + role + "Role"), new object[] { role }) as IRole;
/*            if (role == "Staff")
            {
                Role = new StaffRole(role);
                
            }
            else if (role == "Player")
            {
                Role = new PlayerRole(role);
            }*/
        }

    }
}
