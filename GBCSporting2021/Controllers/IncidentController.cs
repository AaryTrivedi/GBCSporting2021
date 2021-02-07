using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;
using Microsoft.EntityFrameworkCore;

namespace GBCSporting2021.Controllers
{
    public class IncidentController : Controller
    {
        private Context ctx;

        public IncidentController(Context ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult List()
        {
            List<Incident> incidents = ctx.Incidents
                                          .Include(i => i.Customer)
                                          .Include(i => i.Product)
                                          .ToList();
            return View(incidents);
        }
    }
}
