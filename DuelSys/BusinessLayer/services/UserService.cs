using BusinessLayer.interfaces;
using BusinessLayer.models;
using BusinessLayer.validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.services
{
    public class UserService
    {
        private readonly IDALUser _dalUser;
        private readonly UserValidator _userValidator;
        public UserService(IDALUser daluser, UserValidator userval)
        {
            _dalUser = daluser;
            _userValidator = userval;
        }

        public User Login(string username, string password)
        {
            User user = _dalUser.Login(username);
            bool match = Utils.Verify(password, user.Password);
            if (!match)
            {
                throw new Exception("Wrong username or password!");
            }
            return user;
        }
        public bool Register(User user, User loggedUser)
        {
            string hashedPass = Utils.Hash(user.Password);
            if (user is Staff)
            {
                if (loggedUser == null || !loggedUser.Role.CanAccessDesktopApp())
                {
                    throw new Exception("You are not authorized!");
                }
                _userValidator.ValidateStaff((Staff)user);
                return _dalUser.RegisterStaff((Staff)user);
            }
            else if (user is Player)
            {
                _userValidator.ValidatePlayer((Player)user);
                return _dalUser.RegisterPlayer((Player)user);
            }
            else
            {
                return false;
            }
        }
    }
}
