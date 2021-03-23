using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;
using Microsoft.EntityFrameworkCore;

namespace GBCSporting2021.Controllers
{
    public class CustomerController : Controller
    {
        private Context ctx;

        public CustomerController(Context ctx)
        {
            this.ctx = ctx;
        }

        [Route("/customers")]
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
            return View("CustomerForm", new Customer());
        }

        [HttpGet]
        public IActionResult Edit(int identifier)
        {
            Customer customer = ctx.Customers
                                    .Include(c => c.Country)
                                    .First(c => c.CustomerId == identifier);
            List<Country> countries = ctx.Countries.ToList();

            ViewBag.Action = "Edit";
            ViewBag.Countries = countries;

            return View("CustomerForm", customer);
        }

        [HttpGet]
        public IActionResult Delete(int identifier)
        {
            Customer customer = ctx.Customers.Find(identifier);

            return View(customer);
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

            List<Country> countries = ctx.Countries.ToList();
            ViewBag.Action = "Create";
            ViewBag.Countries = countries;

            return View("CustomerForm", customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                ctx.Customers.Update(customer);
                ctx.SaveChanges();
                return RedirectToAction("List");
            }

            List<Country> countries = ctx.Countries.ToList();
            ViewBag.Action = "Edit";
            ViewBag.Countries = countries;

            return View("CustomerForm", customer);
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            ctx.Customers.Remove(customer);
            ctx.SaveChanges();
            return RedirectToAction("List", "Customer");
        }
    }
}
