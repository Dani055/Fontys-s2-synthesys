using AspNetCoreHero.ToastNotification.Abstractions;
using BusinessLayer.models;
using BusinessLayer.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWeb.Pages.Tournaments
{
    public class TournamentDetailsModel : PageModel
    {
        private readonly INotyfService _notyf;
        private readonly TournamentService _tournamentService;
        public Tournament tourney { get; set; }

        [BindProperty(SupportsGet = true)]
        public int tournamentId { get; set; }
        public TournamentDetailsModel(INotyfService notyf, TournamentService ts)
        {
            _notyf = notyf;
            _tournamentService = ts;
        }
        public IActionResult OnGet()
        {
            try
            {
                tourney = _tournamentService.GetTournamentById(tournamentId);
                if (tourney == null)
                {
                    _notyf.Error("Resource not found!");
                    return RedirectToPage("/Tournaments/ViewTournaments");
                }
                return Page();
            }
            catch (Exception ex)
            {
                _notyf.Error(ex.Message);
                return Page();
            }
        }
        public IActionResult OnPostOnRegister()
        {
            try
            {
                bool result = _tournamentService.RegisterPlayerForTournament(tournamentId, HttpContext.Session.GetLoggedUser().Id);
                if (result)
                {
                    _notyf.Success("Successfully registered for tournament");
                }
                return RedirectToPage("/Tournaments/TournamentDetails", new { tournamentId = tournamentId });
            }
            catch (Exception ex)
            {
                _notyf.Error(ex.Message);
                return RedirectToPage("/Tournaments/TournamentDetails", new { tournamentId = tournamentId });
            }
        }
        public void OnPostOnDeregister()
        {

        }
    }
}
