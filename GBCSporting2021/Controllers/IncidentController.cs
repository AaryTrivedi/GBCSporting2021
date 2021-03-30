using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;
using Microsoft.EntityFrameworkCore;
using GBCSporting2021.ViewModels;

namespace GBCSporting2021.Controllers
{
    public class IncidentController : Controller
    {
        private Context ctx;

        public IncidentController(Context ctx)
        {
            this.ctx = ctx;
        }

        [Route("/incidents")]
        public IActionResult List(string filter = "all")
        {
            IncidentListViewModel ilvm = new IncidentListViewModel();
            List<Incident> incidents = new List<Incident>();

            IQueryable<Incident> incidentsQueryable = ctx.Incidents
                                                         .Include(i => i.Customer)
                                                         .Include(i => i.Product);

            if (filter.CompareTo("all") == 0)
            {
                incidents = incidentsQueryable.ToList();
            } else if (filter == "unassigned")
            {
                incidents = incidentsQueryable
                                    .Where(i => i.TechnicianId == null)
                                    .ToList();
            } else
            {
                incidents = incidentsQueryable
                                    .Where(i => i.DateClosed == null)
                                    .ToList();
            }

            ilvm.Incidents = incidents;
            ilvm.FilterType = filter;

            return View(ilvm);
        }

        [HttpGet]
        public IActionResult Add()
        {
            List<Customer> customers = ctx.Customers.ToList();
            List<Product> products = ctx.Products.ToList();
            List<Technician> technicians = ctx.Technicians.ToList();

            IncidentFormViewModel ifvm = new IncidentFormViewModel
            {
                Customers = customers,
                Products = products,
                Technicians = technicians,
                Action = "Create",
                Incident = new Incident()
            };

            return View("IncidentForm", ifvm);
        }

        [HttpGet]
        public IActionResult Edit(int identifier)
        {
            Incident incident = ctx.Incidents
                                   .Include(i => i.Customer)
                                   .Include(i => i.Product)
                                   .Include(i => i.Technician)
                                   .FirstOrDefault(i => i.IncidentId == identifier);

            IncidentFormViewModel ifvm = new IncidentFormViewModel();
            List<Customer> customers = ctx.Customers.ToList();
            List<Product> products = ctx.Products.ToList();
            List<Technician> technicians = ctx.Technicians.ToList();

            ifvm.Customers = customers;
            ifvm.Products = products;
            ifvm.Technicians = technicians;
            ifvm.Incident = incident;
            ifvm.Action = "Edit";

            return View("IncidentForm", ifvm);
        }

        [HttpGet]
        public IActionResult Delete(int identifier)
        {
            Incident incident = ctx.Incidents.Find(identifier);
            return View(incident);
        }

        [HttpPost]
        public IActionResult Create(IncidentFormViewModel ifvm)
        {
            if (ModelState.IsValid)
            {
                ctx.Incidents.Add(ifvm.Incident);
                ctx.SaveChanges();

                TempData["message"] = "Incident with id: " + ifvm.Incident.IncidentId + " created successfully";
                TempData["indicator"] = "success";

                return RedirectToAction("List", "Incident");
            }

            List<Customer> customers = ctx.Customers.ToList();
            List<Product> products = ctx.Products.ToList();
            List<Technician> technicians = ctx.Technicians.ToList();

            ifvm.Customers = customers;
            ifvm.Products = products;
            ifvm.Technicians = technicians;
            ifvm.Action = "Create";

            return View("IncidentForm", ifvm);
        }

        [HttpPost]
        public IActionResult Edit(IncidentFormViewModel ifvm)
        {
            if (ModelState.IsValid)
            {
                ctx.Incidents.Update(ifvm.Incident);

                TempData["message"] = "Incident with id: " + ifvm.Incident.IncidentId + " updated successfully";
                TempData["indicator"] = "success";

                return RedirectToAction("List", "Incident");
            }

            List<Customer> customers = ctx.Customers.ToList();
            List<Product> products = ctx.Products.ToList();
            List<Technician> technicians = ctx.Technicians.ToList();

            ifvm.Customers = customers;
            ifvm.Products = products;
            ifvm.Technicians = technicians;
            ifvm.Action = "Edit";

            return View("IncidentForm", ifvm);
        }

        [HttpPost]
        public IActionResult Delete(Incident incident)
        {
            ctx.Incidents.Remove(incident);
            ctx.SaveChanges();

            TempData["message"] = "Incident with id: " + incident.IncidentId + " deleted successfully";
            TempData["indicator"] = "danger";

            return RedirectToAction("List", "Incident");
        }
    }
}
