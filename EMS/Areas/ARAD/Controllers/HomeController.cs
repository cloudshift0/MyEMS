using Microsoft.AspNetCore.Mvc;

namespace EMS.Areas.ARAD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
