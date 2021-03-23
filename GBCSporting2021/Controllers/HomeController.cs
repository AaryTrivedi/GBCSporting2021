using GBCSporting2021.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GBCSporting2021.Controllers
{
    public class HomeController : Controller
    {
        private Context ctx;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, Context ctx)
        {
            this.ctx = ctx;
            _logger = logger;
        }      

        public IActionResult Index()
        {
            List<Incident> incidents = ctx.Incidents
                                          .Include(i => i.Customer)
                                          .Include(i => i.Product)
                                          .OrderByDescending(i => i.DateOpened)
                                          .Take(5)
                                          .ToList();

            return View(incidents);
        }

        [Route("/about")]
        public IActionResult About()
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
    }
}
