using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_Core_Web_Development_course.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Logs(string something)
        {
            return something;
        }

        public IActionResult Logsview(int id, string Name)
        {
            ViewBag.ID = id;
            ViewBag.Name = Name;
            return View();
        }
    }
}
