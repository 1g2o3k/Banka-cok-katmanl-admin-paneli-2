using Microsoft.AspNetCore.Mvc;

namespace bankawebsite.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Adminvi()
        {
            return View();
        }
    }
}
