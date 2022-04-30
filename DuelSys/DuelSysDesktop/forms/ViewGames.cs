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
    public partial class ViewGames : Form
    {
        public ViewGames()
        {
            InitializeComponent();
        }

        private void btnEditGame_Click(object sender, EventArgs e)
        {
            EditGame eg = new EditGame();
            eg.ShowDialog();
        }
    }
}
