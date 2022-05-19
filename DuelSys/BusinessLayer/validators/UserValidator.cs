using BusinessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.validators
{
    public class UserValidator
    {
        public bool ValidateStaff(Staff staff)
        {
            if (String.IsNullOrEmpty(staff.Username) || staff.Username.Length < 3)
            {
                throw new Exception("Username must be at least 3 characters long!");
            }
            else if (String.IsNullOrEmpty(staff.Password) || staff.Password.Length < 3)
            {
                throw new Exception("Password must be at least 3 characters long!");
            }
            else if (String.IsNullOrEmpty(staff.Firstname))
            {
                throw new Exception("You must enter a first name!");
            }
            else if (String.IsNullOrEmpty(staff.Lastname))
            {
                throw new Exception("You must enter a last name!");
            }
            else if (String.IsNullOrEmpty(staff.Role.RoleName))
            {
                throw new Exception("You must select a role!");
            }
            else if (!Regex.IsMatch(staff.Email, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"))
            {
                throw new Exception("Email must be valid!");
            }
            else if (staff.Salary < 0)
            {
                throw new Exception("Salary cannot be less than 0!");
            }

            return true;
        }
        public bool ValidatePlayer(Player player)
        {
            if (String.IsNullOrEmpty(player.Username) || player.Username.Length < 3)
            {
                throw new Exception("Username must be at least 3 characters long!");
            }
            else if (String.IsNullOrEmpty(player.Password) || player.Password.Length < 3)
            {
                throw new Exception("Password must be at least 3 characters long!");
            }
            else if (String.IsNullOrEmpty(player.Firstname))
            {
                throw new Exception("You must enter a first name!");
            }
            else if (String.IsNullOrEmpty(player.Lastname))
            {
                throw new Exception("You must enter a last name!");
            }
            else if (String.IsNullOrEmpty(player.Role.RoleName))
            {
                throw new Exception("You must select a role!");
            }
            else if (String.IsNullOrEmpty(player.Email) || !Regex.IsMatch(player.Email, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"))
            {
                throw new Exception("Email must be valid!");
            }

            return true;
        }
    }
}
