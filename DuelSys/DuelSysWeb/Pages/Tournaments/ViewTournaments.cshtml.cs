using AspNetCoreHero.ToastNotification.Abstractions;
using BusinessLayer.services;
using BusinessLayer.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWeb.Pages.Tournaments
{
    public class ViewTournamentsModel : PageModel
    {
        private readonly INotyfService _notyf;
        private readonly TournamentService _tournamentService;
        public List<Tournament> tourneys = new List<Tournament>();

        [BindProperty(SupportsGet = true)]
        public string? status { get; set; }
        public ViewTournamentsModel(INotyfService notyf, TournamentService ts)
        {
            _notyf = notyf;
            _tournamentService = ts;
        }
        public void OnGet()
        {
            if (status == null || status == "")
            {
                status = "Pending";
            }
            try
            {
                tourneys = _tournamentService.GetTournaments(status);
            }
            catch (Exception ex)
            {
                _notyf.Error(ex.Message);
            }
        }
    }
}
