using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;

namespace GBCSporting2021.Controllers
{
    public class ProductController : Controller
    {
        private Context ctx { get; set; }

        public ProductController (Context ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult List()
        {
            List<Product> products = ctx.Products.ToList();
            return View(products);
        }
    }
}
