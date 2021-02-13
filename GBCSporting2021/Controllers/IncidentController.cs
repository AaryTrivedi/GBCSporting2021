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

        [HttpGet]
        public IActionResult Add()
        {
            List<Customer> customers = ctx.Customers.ToList();
            List<Product> products = ctx.Products.ToList();
            List<Technician> technicians = ctx.Technicians.ToList();

            ViewBag.Customers = customers;
            ViewBag.Products = products;
            ViewBag.Technicians = technicians;
            ViewBag.Action = "Create";

            return View("IncidentForm");
        }

        [HttpPost]
        public IActionResult Create(Incident incident)
        {
            if (ModelState.IsValid)
            {
                ctx.Incidents.Add(incident);
                ctx.SaveChanges();

                return RedirectToAction("List", "Incident");
            }

            return View("IncidentForm");
        }
    }
}
