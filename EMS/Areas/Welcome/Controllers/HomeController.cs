<<<<<<< Updated upstream
﻿using EMS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
=======
﻿using Microsoft.AspNetCore.Mvc;
>>>>>>> Stashed changes

namespace EMS.Areas.Welcome.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< Updated upstream
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

=======
>>>>>>> Stashed changes
        public IActionResult Index()
        {
            return View();
        }
<<<<<<< Updated upstream

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
=======
>>>>>>> Stashed changes
    }
}
