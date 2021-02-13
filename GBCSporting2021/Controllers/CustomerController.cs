using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;

namespace GBCSporting2021.Controllers
{
    public class CustomerController : Controller
    {
        private Context ctx;

        public CustomerController(Context ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult List()
        {
            List<Customer> customers = ctx.Customers.ToList();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            List<Country> countries = ctx.Countries.ToList();
            ViewBag.Action = "Create";
            ViewBag.Countries = countries;
            return View("CustomerForm");
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                ctx.Customers.Add(customer);
                ctx.SaveChanges();

                return RedirectToAction("List", "Customer");
            }

            return View("CustomerForm");
        }
    }
}
