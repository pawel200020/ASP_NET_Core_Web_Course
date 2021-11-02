using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ASP_NET_Core_Web_Development_course.Models;
using ASP_NET_Core_Web_Development_course.Services;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Bogus;

namespace ASP_NET_Core_Web_Development_course.Controllers
{
    public class ProductController : Controller
    {
        //ProductsDAO repository;
        //HardCodedSampleDataRepository repository;
        public IProductDataService repository { get; set; }
        public ProductController(IProductDataService dataService)
        {
            repository = dataService;
        }
        public IActionResult Index()
        {
            //HardCodedSampleDataRepository hardCodedSampleDataRepository = new HardCodedSampleDataRepository();
            //return View(hardCodedSampleDataRepository.GetAllProducts());            
            return View(repository.GetAllProducts());
        }

        public IActionResult Search(string searchTerm)
        {
            List<ProductModel> productList = repository.SearchProducts(searchTerm);
            return View("index", productList);
        }
        public IActionResult Message()
        {
            return View("message");
        }

        public IActionResult SearchForm()
        {
            return View();
        }

        public IActionResult Welcome(string name, int secnumber = 13)
        {
            ViewBag.Name = name;
            ViewBag.Number = secnumber;
            return View();
        }

        public IActionResult ShowDetails(int id)
        {
            ProductModel foundProduct = repository.GetProductById(id);
            return View(foundProduct);
        }


        public IActionResult ShowDetailsJson(int id)
        {
            ProductModel foundProduct = repository.GetProductById(id);
            return Json(foundProduct);
        }
        public IActionResult ProcessEditReturnPartial(ProductModel product)
        {
            repository.Update(product);
            return PartialView("_productCard", product);
        }


        public IActionResult Edit(int id)
        {
            ProductModel foundProduct = repository.GetProductById(id);
            return View("Edit", foundProduct);
        }
        public IActionResult ProcessEdit(ProductModel product)
        {
            repository.Update(product);
            return View("Index", repository.GetAllProducts());
        }
        public IActionResult Delete(int id)
        {
            ProductModel product = repository.GetProductById(id);
            repository.Delete(product);
            return View("Index", repository.GetAllProducts());
        }
        public IActionResult CreateForm()
        {
            return View();
        }
        public IActionResult ProcessCreate(ProductModel product)
        {
            repository.Insert(product);
            return View("Index", repository.GetAllProducts());
        }
    }
}