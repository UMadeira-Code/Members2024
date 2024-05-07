using Microsoft.AspNetCore.Mvc;

namespace Members.Server.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
