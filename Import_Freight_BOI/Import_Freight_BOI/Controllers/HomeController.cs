using Import_Freight_BOI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using RISTExamOnlineProject.Models.db;
//using RISTExamOnlineProject.Models.TSQL;

namespace Import_Freight_BOI.Controllers
{
    public class HomeController : Controller
    {
        //protected SqlConnection conn = new SqlConnection("Data source=;Initail Catalog=;user ID; password;");
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Login()
        {
            return View();
        }
    }
}
