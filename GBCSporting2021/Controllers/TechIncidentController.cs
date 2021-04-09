using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;
using GBCSporting2021.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace GBCSporting2021.Controllers
{
    public class TechIncidentController : Controller
    {

        private Context ctx;

        public TechIncidentController(Context ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult GetTechnician(int identifier = -1)
        {
            if (identifier != -1)
            {
                return RedirectToAction();
            }

            List<SelectListItem> technicians = ctx.Technicians.ToList().ConvertAll(t => {
                return new SelectListItem()
                {
                    Text = t.Name,
                    Value = t.TechnicianId.ToString(),
                    Selected = false
                };
            });

            TechIncidentGetViewModel tigvm = new TechIncidentGetViewModel();
            tigvm.Technicians = technicians;
            return View(tigvm);
        }

        [HttpPost]
        public IActionResult RedirectToList(TechIncidentGetViewModel tigvm)
        {
            if (tigvm.TechnicianId != -1)
            {
                return RedirectToAction("List", "TechIncident", new { identifier = tigvm.TechnicianId });
            }

            TempData["message"] = "Please select a valid Technician";
            TempData["indicator"] = "danger";
            return RedirectToAction("GetTechnician", "TechIncident");
        }

        public IActionResult List(int identifier)
        {
            Technician technician = ctx.Technicians.FirstOrDefault(t => t.TechnicianId == identifier);

            if (technician == null)
            {
                TempData["message"] = "Please select a valid Technician";
                TempData["indicator"] = "danger";
                return RedirectToAction("GetTechnician", "TechIncident");
            }

            List<Incident> techIncidents = ctx.Incidents
                                              .Include(i => i.Customer)
                                              .Include(i => i.Product)
                                              .Where(Incident => Incident.TechnicianId == identifier && Incident.DateClosed == null)
                                              .ToList();

            TechIncidentListViewModel tilvm = new TechIncidentListViewModel();

            tilvm.Technician = technician;
            tilvm.Incidents = techIncidents;

            HttpContext.Session.SetInt32("TechnicianId", identifier);

            return View(tilvm);
        }

        [HttpGet]
        public IActionResult EditIncident(int identifier)
        {
            if (!HttpContext.Session.GetInt32("TechnicianId").HasValue)
            {
                TempData["message"] = "Please select a valid Technician";
                TempData["indicator"] = "danger";
                return RedirectToAction("GetTechnician", "TechIncident");
            }

            Incident incident = ctx.Incidents
                                   .Include(i => i.Technician)
                                   .Include(i => i.Customer)
                                   .Include(i => i.Product)
                                   .FirstOrDefault(i => i.IncidentId == identifier);

            int? TechnicianId = HttpContext.Session.GetInt32("TechnicianId");
            if (incident == null)
            {
                TempData["message"] = "Please select a valid Incident";
                TempData["indicator"] = "danger";
                return RedirectToAction("List", "TechIncident", new { identifier = TechnicianId });
            }

            if (incident.TechnicianId != TechnicianId)
            {
                TempData["message"] = "This incident does not belong to selected technician.";
                TempData["indicator"] = "danger";
                return RedirectToAction("List", "TechIncident", new { identifier = TechnicianId });
            }

            return View("IncidentForm", incident);
        }

        [HttpPost]
        public IActionResult EditIncident(Incident incident)
        {
            int? id = HttpContext.Session.GetInt32("TechnicianId");

            if (ModelState.IsValid)
            {
                ctx.Incidents.Update(incident);
                ctx.SaveChanges();
                if (id.HasValue)
                {
                    return RedirectToAction("List", "TechIncident", new { identifier = id });
                }
                else
                {
                    TempData["message"] = "Session cleared for safety concerns. Please select again.";
                    TempData["indicator"] = "warning";
                    return RedirectToAction("GetTechnician", "TechIncident");
                }
            }

            int? identifier = id;

            if (!HttpContext.Session.GetInt32("TechnicianId").HasValue)
            {
                TempData["message"] = "Please select a valid Technician";
                TempData["indicator"] = "danger";
                return RedirectToAction("GetTechnician", "TechIncident");
            }

            if (incident == null)
            {
                TempData["message"] = "Please select a valid Incident";
                TempData["indicator"] = "danger";
                return RedirectToAction("List", "TechIncident", new { identifier = id });
            }

            if (incident.TechnicianId != identifier)
            {
                TempData["message"] = "This incident does not belong to selected technician.";
                TempData["indicator"] = "danger";
                return RedirectToAction("List", "TechIncident", new { identifier = id });
            }

            return View("IncidentForm", incident);
        }
    }
}
