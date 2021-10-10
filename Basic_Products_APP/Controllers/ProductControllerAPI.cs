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
using System.Web.Http.Description;

namespace ASP_NET_Core_Web_Development_course.Controllers
{
    [ApiController]
    [Route("api/")]
    public class ProductControllerAPI : ControllerBase
    {
        //[HttpGet]
        //public ActionResult<IEnumerable<ProductModelDTO>> Index()
        //{
        //    //HardCodedSampleDataRepository hardCodedSampleDataRepository = new HardCodedSampleDataRepository();
        //    //return View(hardCodedSampleDataRepository.GetAllProducts());
        //    ProductsDAO products = new ProductsDAO();
        //    List<ProductModel> productsList = products.GetAllProducts();
        //    List<ProductModelDTO> productListExt = new List<ProductModelDTO>();
        //    //first idea
        //    foreach (var item in productsList)
        //    {
        //        productListExt.Add(new ProductModelDTO(item));
        //    }
        //    //another idea is to use link laguage i c#
        //    //IEnumerable<ProductModelDTO> ProductListExt2 = from p in productsList select new ProductModelDTO(p);
        //    return productListExt;
        //}

        [HttpGet]
        [ResponseType(typeof(List<ProductModelDTO>))]
        public IEnumerable<ProductModelDTO> Index()
        {
            ProductsDAO products = new ProductsDAO();
            List<ProductModel> productsList = products.GetAllProducts();
            //another idea is to use link laguage i c#
            IEnumerable<ProductModelDTO> ProductListExt = from p in productsList select new ProductModelDTO(p);
            return ProductListExt;
        }



        [HttpGet("searchproducts/{searchTerm}")]
        [ResponseType(typeof(List<ProductModelDTO>))]
        public IEnumerable<ProductModelDTO> Search(string searchTerm)
        {
            ProductsDAO products = new ProductsDAO();
            List<ProductModel> productList = products.SearchProducts(searchTerm);
            IEnumerable<ProductModelDTO> ProductListExt = from p in productList select new ProductModelDTO(p);
            return ProductListExt;

           
        }
        [HttpGet("ShowDetails/{Id}")]
        public ActionResult<ProductModelDTO> ShowDetails(int id)
        {
            ProductsDAO product = new ProductsDAO();
            ProductModel foundProduct = product.GetProductById(id);
            ProductModelDTO foundProductExt = new ProductModelDTO(foundProduct);
            return foundProductExt;
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
