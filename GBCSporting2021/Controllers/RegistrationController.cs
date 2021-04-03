using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;
using GBCSporting2021.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace GBCSporting2021.Controllers
{
    public class RegistrationController : Controller
    {

        private Context ctx;
        public RegistrationController(Context context)
        {
            ctx = context;
        }

        [HttpGet]
        public IActionResult GetCustomer()
        {
            RegistrationCustomerViewModel rcvm = new RegistrationCustomerViewModel();
            List<Customer> customers = ctx.Customers.ToList();
            rcvm.Customers = customers;
            return View(rcvm);
        }

        [HttpPost]
        public IActionResult GetCustomer(RegistrationCustomerViewModel rcvm)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Registrations", "Registration", new { identifier = rcvm.Id });
            }
            List<Customer> customers = ctx.Customers.ToList();
            rcvm.Customers = customers;
            return View(rcvm);
        }

        [Route("/registrations")]
        [HttpGet]
        public IActionResult Registrations(int identifier = -1)
        {
            if (identifier == -1)
            {
                TempData["message"] = "Please select a valid customer";
                TempData["indicator"] = "danger";
                return RedirectToAction("GetCustomer", "Registration");
            }

            Customer customer = ctx.Customers
                                   .Find(identifier);

            List<Registration> registrations = ctx.Registrations
                                                  .Include(r => r.Product)
                                                  .Where(r => r.CustomerId == identifier)
                                                  .ToList();

            List<Product> products = ctx.Products.ToList();

            RegistrationProductsViewModel rpvm = new RegistrationProductsViewModel();

            rpvm.Customer = customer;
            rpvm.Registrations = registrations;
            rpvm.Products = products;

            HttpContext.Session.SetInt32("CustomerId", identifier);

            return View(rpvm);
        }

        [HttpPost]
        [Route("/registrations")]
        public IActionResult Registrations(RegistrationProductsViewModel rpvm)
        {
            int? identifier = HttpContext.Session.GetInt32("CustomerId");

            if (identifier is null)
            {
                TempData["message"] = "Please select a valid customer";
                TempData["indicator"] = "Danger";
                return RedirectToAction("GetCustomer", "Registration");
            }

            if (ModelState.IsValid)
            {
                Registration registration = new Registration();
                registration.CustomerId = (int) identifier;
                registration.ProductId = rpvm.ProductId;
                ctx.Registrations.Add(registration);
                ctx.SaveChanges();
            }

            Customer customer = ctx.Customers.Find(identifier);

            List<Registration> registrations = ctx.Registrations
                                                  .Include(r => r.Product)
                                                  .Where(r => r.CustomerId == identifier)
                                                  .ToList();

            List<Product> products = ctx.Products.ToList();

            rpvm.Customer = customer;
            rpvm.Registrations = registrations;
            rpvm.Products = products;

            HttpContext.Session.SetInt32("CustomerId", rpvm.Customer.CustomerId);

            return View(rpvm);
        }

        [HttpGet]
        public IActionResult Delete(int identifier = -1)
        {
            if (identifier == -1)
            {
                if (HttpContext.Session.GetInt32("CustomerId").HasValue)
                {
                    TempData["message"] = "Please select a valid Product";
                    TempData["indicator"] = "Danger";
                    return RedirectToAction("Registrations", "Registration");
                } else
                {
                    TempData["message"] = "Please select a valid customer";
                    TempData["indicator"] = "Danger";
                    return RedirectToAction("GetCustomer", "Registration");
                }
            }
            if (HttpContext.Session.GetInt32("CustomerId").HasValue)
            {
                ViewBag.CustomerId = HttpContext.Session.GetInt32("CustomerId");
                Registration registration = ctx.Registrations.Find(identifier);
                return View(registration);
            }
            TempData["message"] = "Please select a valid customer";
            TempData["indicator"] = "Danger";
            return RedirectToAction("GetCustomer", "Registration");
        }

        [HttpPost]
        public IActionResult Delete(Registration registration)
        {
            ctx.Registrations.Remove(registration);
            ctx.SaveChanges();
            int? CustomerId = HttpContext.Session.GetInt32("CustomerId");
            return RedirectToAction("Registrations", "Registration", new { identifier = CustomerId });
        }
    }
}
