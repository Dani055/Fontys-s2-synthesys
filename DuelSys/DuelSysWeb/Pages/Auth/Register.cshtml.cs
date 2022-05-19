using AspNetCoreHero.ToastNotification.Abstractions;
using BusinessLayer.models;
using BusinessLayer.services;
using BusinessLayer.roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWeb.Pages.Auth
{
    public class RegisterModel : PageModel
    {
        private readonly INotyfService _notyf;
        private readonly UserService _userService;

        [BindProperty]
        public Player user { get; set; }

        public RegisterModel(UserService userServ, INotyfService notyf)
        {
            _userService = userServ;
            _notyf = notyf;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            try
            {
                user.Role = new PlayerRole("Player");
                _userService.Register(user, HttpContext.Session.GetLoggedUser());
                _notyf.Success("User registered successfully!");
                return RedirectToPage("/Auth/Login");
            }
            catch (Exception ex)
            {
                _notyf.Error(ex.Message);
                return Page();
            }
        }
    }
}
