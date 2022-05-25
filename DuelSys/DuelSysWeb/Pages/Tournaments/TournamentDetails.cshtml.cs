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
        private readonly MatchService _matchService;

        [BindProperty]
        public Tournament tourney { get; set; }


        [BindProperty(SupportsGet = true)]
        public int tournamentId { get; set; }
        public TournamentDetailsModel(INotyfService notyf, TournamentService ts, MatchService ms)
        {
            _notyf = notyf;
            _tournamentService = ts;
            _matchService = ms;
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
                tourney.standings = _tournamentService.GetTournamentStandings(tournamentId);
                tourney.matches = _matchService.GetMatches(tournamentId);
                foreach (TourneyMatch m in tourney.matches)
                {
                    if (m.Player1.Id == 0)
                    {
                        m.Player1.Firstname = "(Unknown)";
                    }
                    if (m.Player2.Id == 0)
                    {
                        m.Player2.Firstname = "(Unknown)";
                    }
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
                else {
                    _notyf.Error("Maximum amount of registered players has been reached");
                }
                return RedirectToPage("/Tournaments/TournamentDetails", new { tournamentId = tournamentId });
            }
            catch (Exception ex)
            {
                _notyf.Error(ex.Message);
                return RedirectToPage("/Tournaments/TournamentDetails", new { tournamentId = tournamentId });
            }
        }
        public IActionResult OnPostOnDeregister()
        {
            try
            {
                bool result = _tournamentService.DeregisterPlayerForTournament(tournamentId, HttpContext.Session.GetLoggedUser().Id);
                if (result)
                {
                    _notyf.Success("Successfully deregistered from tournament");
                }

                return RedirectToPage("/Tournaments/TournamentDetails", new { tournamentId = tournamentId });
            }
            catch (Exception ex)
            {
                _notyf.Error(ex.Message);
                return RedirectToPage("/Tournaments/TournamentDetails", new { tournamentId = tournamentId });
            }
        }
    }
}
