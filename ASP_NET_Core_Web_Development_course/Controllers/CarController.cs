using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_NET_Core_Web_Development_course.Services;

namespace ASP_NET_Core_Web_Development_course.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            HardCodedSampleDataRepositoryCars hardCodedSampleDataRepository = new HardCodedSampleDataRepositoryCars();
            return View(hardCodedSampleDataRepository.GetAllProducts());
        }
    }
}
