using BusinessLayer.services;
using Microsoft.Extensions.DependencyInjection;
using BusinessLayer.models;
using BusinessLayer.interfaces;
using BusinessLayer.tournament_systems;

namespace DuelSysDesktop.forms
{
    public partial class EditTournament : Form
    {
        private int tourId;
        private readonly TournamentService _tournamentService;
        private Tournament tourney;
        public EditTournament(int tourId)
        {
            InitializeComponent();
            this.tourId = tourId;
            _tournamentService = Program.ServiceProvider.GetService<TournamentService>();
            PopulateFields();
            
        }
        public void PopulateFields()
        {
            tourney = _tournamentService.GetTournamentById(tourId);
            tbName.Text = tourney.Name;
            tbDesc.Text = tourney.Description;
            cbSport.Text = tourney.SportName;
            dtStart.Value = tourney.StartDate;
            dtEnd.Value = tourney.EndDate;
            tbMinPlayers.Value = tourney.MinPlayers;
            tbMaxPlayers.Value = tourney.MaxPlayers;
            tbLocation.Text = tourney.Location;
            cbSystem.Text = tourney.System.SystemName;
        }

        private void btnEditTourney_Click(object sender, EventArgs e)
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
                Id = tourId,
                Name = name,
                SportName = sport,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                MinPlayers = minPlayers,
                MaxPlayers = maxPlayers,
                Location = location,
                HasStarted = false
            };
            tourney.System = new Round_robin_system(tourney, system);
            try
            {
                bool result = _tournamentService.EditTournament(tourney, DesktopUtils.loggedUser);
                if (result)
                {
                    DesktopUtils.ShowInfo("Tournament edited!");
                    
                }
            }
            catch (Exception ex)
            {
                DesktopUtils.ShowError(ex.Message);
            }
        }
    }
}
