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

        [HttpGet]
        public IActionResult List()
        {
            List<Product> products = ctx.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Create";
            return View("ProductForm", new Product());
        }

        [HttpGet]
        public IActionResult Edit(int identifier)
        {
            Product product = ctx.Products.Find(identifier);

            ViewBag.Action = "Edit";

            return View("ProductForm", product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                ctx.Products.Add(product);
                ctx.SaveChanges();

                return RedirectToAction("List", "Product");
            }

            return View("ProductForm", product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                ctx.Products.Update(product);
                ctx.SaveChanges();
                return RedirectToAction("List", "Product");
            }

            return View("ProductForm", product);
        }
    }
}
