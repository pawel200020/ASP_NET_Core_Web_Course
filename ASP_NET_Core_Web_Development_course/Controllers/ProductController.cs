using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_NET_Core_Web_Development_course.Models;
using ASP_NET_Core_Web_Development_course.Services;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Bogus;

namespace ASP_NET_Core_Web_Development_course.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //HardCodedSampleDataRepository hardCodedSampleDataRepository = new HardCodedSampleDataRepository();
            //return View(hardCodedSampleDataRepository.GetAllProducts());
            ProductsDAO products = new ProductsDAO();
            return View(products.GetAllProducts());
        }

        public IActionResult Search(string searchTerm)
        {
            ProductsDAO products = new ProductsDAO();
            List<ProductModel> productList = products.SearchProducts(searchTerm);
            return View("index",productList);
        }
        public IActionResult  Message()
        {
            return View("message");
        }

        public IActionResult SearchForm()
        {
            return View();
        }

        public IActionResult Welcome(string name, int secnumber=13)
        {
            ViewBag.Name = name;
            ViewBag.Number = secnumber;
            return View();
        }
    }
}
