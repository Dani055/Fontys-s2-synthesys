using Microsoft.Extensions.DependencyInjection;
using BusinessLayer.services;
using DuelSysDesktop.forms;
using BusinessLayer.models;

namespace DuelSysDesktop
{
    public partial class Form1 : Form
    {
        private readonly UserService _userService;
        public Form1()
        {
            InitializeComponent();
            _userService = Program.ServiceProvider.GetService<UserService>();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            try
            {
                User result = _userService.Login(username, password);
                if (result != null)
                {
                    if (!result.Role.CanAccessDesktopApp())
                    {
                        MessageBox.Show("You are not a staff member");
                        return;
                    }
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                    DesktopUtils.loggedUser = result;
                    Home home = new Home();
                    this.Hide();
                    home.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}