using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Client.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult World([FromQuery] string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}
