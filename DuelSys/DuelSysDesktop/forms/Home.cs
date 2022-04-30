using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuelSysDesktop.forms
{
    public partial class Home : Form
    {
        bool closedByButton = false;

        public Home()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            tmr.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            closedByButton = true;
            this.Dispose();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closedByButton)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            RegisterAccount ra = new RegisterAccount();
            ra.ShowDialog();        
        }

        private void btnCreateTouney_Click(object sender, EventArgs e)
        {
            CreateTournament ct = new CreateTournament();
            ct.ShowDialog();
        }

        private void btnEditTourney_Click(object sender, EventArgs e)
        {
            EditTournament et = new EditTournament();
            et.ShowDialog();
        }

        private void btnViewTourney_Click(object sender, EventArgs e)
        {
            ViewGames vg = new ViewGames();
            vg.ShowDialog();
        }
    }
}
