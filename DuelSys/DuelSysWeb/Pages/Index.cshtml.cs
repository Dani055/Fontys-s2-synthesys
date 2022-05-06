using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly INotyfService _notyf;

        public IndexModel(ILogger<IndexModel> logger, INotyfService notyf)
        {
            _logger = logger;
            _notyf = notyf;
        }

        public void OnGet()
        {
            _notyf.Success("xd");
        }
    }
}