using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace ASP_NET_Core_Web_Development_course.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult  Message()
        {
            return View("message");
        }

        public IActionResult Welcome(string name, int secnumber=13)
        {
            ViewBag.Name = name;
            ViewBag.Number = secnumber;
            return View();
        }
    }
}
