using BusinessLayer.models;
using BusinessLayer.services;
using Microsoft.Extensions.DependencyInjection;

namespace DuelSysDesktop.forms
{
    public partial class ViewGames : Form
    {
        private readonly TournamentService _tournamentService;
        private readonly MatchService _matchService;

        private List<TourneyStanding> standings = new List<TourneyStanding>();
        private List<TourneyMatch> matches = new List<TourneyMatch>();
        private Tournament tourney = null;
        private int tourneyId;
        public ViewGames(int tourneyId)
        {
            InitializeComponent();
            _tournamentService = Program.ServiceProvider.GetService<TournamentService>();
            _matchService = Program.ServiceProvider.GetService<MatchService>();
            this.tourneyId = tourneyId;

            LoadTournamentInfo();
            LoadGames();
            
        }

        private void btnEditGame_Click(object sender, EventArgs e)
        {
            TourneyMatch match = null;
            try
            {
                match = lvMatches.SelectedItems[0].Tag as TourneyMatch;
            }
            catch (ArgumentOutOfRangeException)
            {
                DesktopUtils.ShowError("Select a game first!");
                return;
            }
            EditGame eg = new EditGame(match);
            eg.ShowDialog();
            if (DesktopUtils.UpdateContent)
            {
                DesktopUtils.UpdateContent = false;
                LoadGames();
            }
        }
        private void LoadTournamentInfo()
        {
            tourney = _tournamentService.GetTournamentById(tourneyId);
            standings = _tournamentService.GetTournamentStandings(tourneyId);
            if (tourney == null)
            {
                DesktopUtils.ShowError("Tournament not found!");
                this.Dispose();
            }
            lblEndDate.Text = tourney.EndDate.ToShortDateString();
            lblStartDate.Text = tourney.StartDate.ToShortDateString();
            lblTourneyName.Text = tourney.Name;
            lblRegisteredPlayers.Text = standings.Count().ToString();
        }
        private void LoadGames()
        {
            try
            {
                matches = _matchService.GetMatches(tourneyId);
            }
            catch (Exception ex)
            {
                DesktopUtils.ShowError(ex.Message);
            }
            
            lvMatches.Items.Clear();
            foreach (TourneyMatch m in matches)
            {
                string[] row = { m.Id.ToString(), m.TournamentId.ToString(), m.DateHeld.ToString(), m.Player1id.ToString(), m.Player1Firstname, m.Player1Lastname, m.Player1Points.ToString(), m.Player2id.ToString(), m.Player2Firstname, m.Player2Lastname, m.Player2Points.ToString(), m.WinnerId.ToString()};

                ListViewItem lv = new ListViewItem(row);
                lv.SubItems[2].BackColor = Color.Yellow;
                lv.SubItems[4].BackColor = Color.Pink;
                lv.SubItems[5].BackColor = Color.Pink;
                lv.SubItems[6].BackColor = Color.Pink;
                lv.SubItems[8].BackColor = Color.Aqua;
                lv.SubItems[9].BackColor = Color.Aqua;
                lv.SubItems[10].BackColor = Color.Aqua;
                lv.SubItems[11].BackColor = Color.ForestGreen;
                lv.Tag = m;
                lv.UseItemStyleForSubItems = false;

                lvMatches.Items.Add(lv);
            }
        }
    }
}
