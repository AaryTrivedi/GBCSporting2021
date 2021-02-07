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
    }
}
