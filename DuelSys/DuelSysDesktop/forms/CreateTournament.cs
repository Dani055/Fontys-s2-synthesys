using BusinessLayer.models;
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

namespace DuelSysDesktop.forms
{
    public partial class CreateTournament : Form
    {
        private readonly TournamentService _tournamentService;
        public CreateTournament()
        {
            InitializeComponent();
            _tournamentService = Program.ServiceProvider.GetService<TournamentService>();
            cbSport.SelectedIndex = 0;
            cbSystem.SelectedIndex = 0;
        }

        private void btnCreateTourney_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string sport = cbSport.SelectedItem.ToString();
            string description = tbDesc.Text;
            DateTime startDate = dtStart.Value;
            DateTime endDate = dtEnd.Value;
            int minPlayers = (int)tbMinPlayers.Value;
            int maxPlayers = (int)tbMaxPlayers.Value;

            string location = tbLocation.Text;
            string system = cbSystem.SelectedItem.ToString();

            Tournament tourney = new Tournament()
            {
                Name = name,
                SportName = sport,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                MinPlayers = minPlayers,
                MaxPlayers = maxPlayers,
                Location = location,
                SystemName = system,
                HasStarted = false
            };
            try
            {
                bool result = _tournamentService.CreateTournament(tourney, DesktopUtils.loggedUser);
                if (result)
                {
                    DesktopUtils.ShowInfo("Tournament created!");
                }
            }
            catch (Exception ex)
            {
                DesktopUtils.ShowError(ex.Message);
            }
                
            
        }
    }
}
