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

        [Route("/technicians")]
        public IActionResult List()
        {
            List<Technician> technicians = ctx.Technicians.ToList();
            return View(technicians);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Create";
            return View("TechnicianForm", new Technician());
        }

        [HttpGet]
        public IActionResult Edit(int identifier)
        {
            Technician technician = ctx.Technicians.Find(identifier);

            ViewBag.Action = "Edit";

            return View("TechnicianForm", technician);
        }

        [HttpGet]
        public IActionResult Delete(int identifier)
        {
            Technician technician = ctx.Technicians.Find(identifier);

            return View(technician);
        }

        [HttpPost]
        public IActionResult Create(Technician technician)
        {
            if (ModelState.IsValid)
            {
                ctx.Technicians.Add(technician);
                ctx.SaveChanges();

                TempData["message"] = "Technician with id: " + technician.TechnicianId + " created successfully";
                TempData["indicator"] = "success";

                return RedirectToAction("List", "Technician");
            }

            ViewBag.Action = "Create";
            return View("TechnicianForm", technician);
        }

        [HttpPost]
        public IActionResult Edit(Technician technician)
        {
            if (ModelState.IsValid)
            {
                ctx.Technicians.Update(technician);
                ctx.SaveChanges();

                TempData["message"] = "Technician with id: " + technician.TechnicianId + " updated successfully";
                TempData["indicator"] = "success";

                return RedirectToAction("List", "Technician");
            }

            ViewBag.Action = "Edit";
            return View("TechnicianForm", technician);
        }

        [HttpPost]
        public IActionResult Delete(Technician technician)
        {
            ctx.Technicians.Remove(technician);
            ctx.SaveChanges();

            TempData["message"] = "Technician with id: " + technician.TechnicianId + " deleted successfully";
            TempData["indicator"] = "danger";

            return RedirectToAction("List");
        }
    }
}
