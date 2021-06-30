using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            var registrationModel = new Registration();

            return View(registrationModel);
        }

        public IActionResult PostRegistrationData(Registration registrationModel)
        {
            if (!ModelState.IsValid)
            {
                return View("index", registrationModel);
            }
            return View(registrationModel);
        }
    }
}
