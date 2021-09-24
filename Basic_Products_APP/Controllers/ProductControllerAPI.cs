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
    [ApiController]
    [Route("api/")]
    public class ProductControllerAPI : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> Index()
        {
            //HardCodedSampleDataRepository hardCodedSampleDataRepository = new HardCodedSampleDataRepository();
            //return View(hardCodedSampleDataRepository.GetAllProducts());
            ProductsDAO products = new ProductsDAO();
            return products.GetAllProducts();
        }
        [HttpGet("searchproducts/{searchTerm}")]
        public ActionResult<IEnumerable<ProductModel>> Search(string searchTerm)
        {
            ProductsDAO products = new ProductsDAO();
            List<ProductModel> productList = products.SearchProducts(searchTerm);
            return productList;
        }
        [HttpGet("ShowDetails/{Id}")]
        public ActionResult<ProductModel> ShowDetails(int id)
        {
            ProductsDAO product = new ProductsDAO();
            ProductModel foundProduct = product.GetProductById(id);
            return foundProduct;
        }
        [HttpPost("ProcessCreate")]
        public ActionResult <int> ProcessCreate(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            int newID = products.Insert(product);
            return newID;
        }
        [HttpPut("ProcessEdit")]
        public ActionResult <ProductModel> ProcessEdit(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Update(product);
            return products.GetProductById(product.Id);
        }
        [HttpDelete("DeleteOne/{Id}")]
        public ActionResult<int> Delete(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel product = products.GetProductById(id);
            int res = products.Delete(product);
            return res;

        }
    }
}
