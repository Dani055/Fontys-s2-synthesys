using AspNetCoreHero.ToastNotification.Abstractions;
using BusinessLayer.models;
using BusinessLayer.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWeb.Pages.Auth
{
    public class LoginModel : PageModel
    {
        private readonly INotyfService _notyf;
        private readonly UserService _userService;

        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public LoginModel(UserService userServ, INotyfService notyf)
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
                User result = _userService.Login(Username, Password);
                if (result != null)
                {
                    HttpContext.Session.SetObject("loggedUser", result);
                    return RedirectToPage("/Index");
                }
                else
                {
                    return Page();
                }
            }
            catch (Exception ex)
            {
                _notyf.Error(ex.Message);
                return Page();
            }
        }
    }
}
