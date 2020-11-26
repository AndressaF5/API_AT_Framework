using Microsoft.AspNetCore.Mvc;

namespace API_AT_Framework.Controllers
{
    public class HeroesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
