using BusinessLayer.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using BusinessLayer.models;
using BusinessLayer.roles;
using BusinessLayer.interfaces;
using System.Reflection;

namespace DuelSysDesktop.forms
{
    public partial class RegisterAccount : Form
    {
        private readonly UserService _userService;
        public RegisterAccount()
        {
            InitializeComponent();
            _userService = Program.ServiceProvider.GetService<UserService>();
            cbxRole.SelectedIndex = 0;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            string email = tbxEmail.Text;
            string firstname = tbxFirstName.Text;
            string lastname = tbxLastName.Text;
            string address = tbxAddress.Text;
            string role = cbxRole.SelectedItem.ToString();
            double salary = Double.Parse(tbxSalary.Value.ToString());

            User u = null;

            if (role == "Staff")
            {
                u = new Staff()
                {
                    Username = username,
                    Password = password,
                    Email = email,
                    Firstname = firstname,
                    Lastname = lastname,
                    Address = address,
                    Salary = salary
                };
            }
            else if(role == "Player")
            {
                u = new Player()
                {
                    Username = username,
                    Password = password,
                    Email = email,
                    Firstname = firstname,
                    Lastname = lastname,
                    Address = address,
                };
            }
            var type = Type.GetType("BusinessLayer.roles." + role + "Role,BusinessLayer");
            u.Role = Activator.CreateInstance(type, new object[] { role }) as IRole;
            try
            {
                bool result = _userService.Register(u, DesktopUtils.loggedUser);
                if (result)
                {
                    DesktopUtils.ShowInfo("User registered successfully!");
                }
            }
            catch (Exception ex)
            {
                DesktopUtils.ShowError(ex.Message);
            }

        }

        private void cbxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRole.SelectedItem.ToString() == "Player")
            {
                tbxSalary.Enabled = false;
            }
            else
            {
                tbxSalary.Enabled = true;
            }
        }
    }
}
