using BusinessLayer.models;
using BusinessLayer.services;
using Microsoft.Extensions.DependencyInjection;

namespace DuelSysDesktop.forms
{
    public partial class EditGame : Form
    {
        private readonly MatchService _matchService;
        private TourneyMatch match = null;
        public EditGame(TourneyMatch m)
        {
            InitializeComponent();
            _matchService = Program.ServiceProvider.GetService<MatchService>();

            match = m;
            if (match == null)
            {
                this.Dispose();
            }
            LoadMatchInfo();
        }
        private void LoadMatchInfo()
        {
            lblDate.Text = match.DateHeld.ToString();
            if (match.Player1.Id == 0)
            {
                lblP1Name.Text = "(Unkown)";
            }
            else
            {
                lblP1Name.Text = match.Player1.Firstname + " " + match.Player1.Lastname;
            }
            if (match.Player2.Id == 0)
            {
                lblP2Name.Text = "(Unkown)";
            }
            else
            {
                lblP2Name.Text = match.Player2.Firstname + " " + match.Player2.Lastname;
            }
            tbxP1pts.Value = match.Player1Points;
            tbxP2pts.Value = match.Player2Points;
        }

        private void btnEditGame_Click(object sender, EventArgs e)
        {
            try
            {
                match.Player1Points = (int)tbxP1pts.Value;
                match.Player2Points = (int)tbxP2pts.Value;
                bool result = _matchService.EnterMatchResult(match, DesktopUtils.loggedUser);
                if (result)
                {
                    DesktopUtils.ShowInfo("Result entered successfully");
                    DesktopUtils.UpdateContent = true;
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                DesktopUtils.ShowError(ex.Message);
            }
        }
    }
}
