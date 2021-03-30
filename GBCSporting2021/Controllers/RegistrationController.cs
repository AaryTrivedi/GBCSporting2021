using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;

namespace GBCSporting2021.Controllers
{
    public class RegistrationController : Controller
    {

        private Context ctx;
        public RegistrationController(Context context)
        {
            ctx = context;
        }

        public IActionResult List()
        {
            List<Registration> registrations = ctx.Registrations.ToList();
            return View(registrations);
        }
    }
}
