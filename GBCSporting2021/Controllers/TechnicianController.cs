using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;

namespace GBCSporting2021.Controllers
{
    public class TechnicianController : Controller
    {
        private Context ctx { get; set; }

        public TechnicianController(Context ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult List()
        {
            List<Technician> technicians = ctx.Technicians.ToList();
            return View(technicians);
        }
    }
}
