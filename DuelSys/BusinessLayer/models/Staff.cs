using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.models
{
    public class Staff : User
    {
        public double Salary { get; set; }
        public Staff()
        { 
        }

        public Staff(int id, string username, string password, string email, string address , string firstname, string lastname, string role, double Salary) : base(id, username, password, email, address ,firstname, lastname, role)
        {
            this.Salary = Salary;
        }
    }
}
