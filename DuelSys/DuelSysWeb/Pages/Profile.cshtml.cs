using BusinessLayer.models;
using BusinessLayer.services;
using AspNetCoreHero.ToastNotification.Abstractions;
using BusinessLayer.roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWeb.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly INotyfService _notyf;
        private readonly MatchService _matchService;
        private readonly TournamentService _tournamentService;
        public User user { get; set; }
        public List<TourneyMatch> matches { get; set; }
        public List<TourneyStanding> standings { get; set; }
        public ProfileModel(INotyfService notyf, MatchService ms, TournamentService ts)
        {
            _notyf = notyf;
            _matchService = ms;
            _tournamentService = ts;
        }
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetLoggedUser() == null)
            {
                _notyf.Error("You are not logged in!");
                return RedirectToPage("/Index");
            }
            user = HttpContext.Session.GetLoggedUser();
            matches = _matchService.GetMyMatches(user.Id);
            standings = _tournamentService.GetTournamentParticipation(user.Id);
            return Page();
        }
    }
}
