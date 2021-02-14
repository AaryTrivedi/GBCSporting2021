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

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Create";
            return View("TechnicianForm");
        }

        [HttpGet]
        public IActionResult Edit(int identifier)
        {
            Technician technician = ctx.Technicians.Find(identifier);

            ViewBag.Action = "Edit";

            return View("TechnicianForm", technician);
        }

        [HttpPost]
        public IActionResult Create(Technician technician)
        {
            if (ModelState.IsValid)
            {
                ctx.Technicians.Add(technician);
                ctx.SaveChanges();

                return RedirectToAction("List", "Technician");
            }

            return View("TechnicianForm", technician);
        }

        [HttpPost]
        public IActionResult Edit(Technician technician)
        {
            if (ModelState.IsValid)
            {
                ctx.Technicians.Update(technician);
                ctx.SaveChanges();
                return RedirectToAction("List", "Technician");
            }

            return View("TechnicianForm", technician);
        }
    }
}
