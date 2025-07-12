using Microsoft.AspNetCore.Mvc;

namespace EMS.Areas.ARFM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
