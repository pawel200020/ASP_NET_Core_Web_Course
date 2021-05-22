using ASP_NET_Core_Web_Development_course.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_Core_Web_Development_course.Services
{
    public class HardCodedSampleDataRepository : IProductDataService
    {
        static List<ProductModel> productList = new List<ProductModel>();

        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> productList = new List<ProductModel>();
            if (productList.Count == 0)
            {
                productList.Add(new ProductModel
                    {Id = 1, Name = "Mouse Pad", price = 5.99m, Description = "enter a desc here"});
                productList.Add(new ProductModel
                    {Id = 2, Name = "Web Cam", price = 45.99m, Description = "enter a desc here"});
                productList.Add(new ProductModel
                    {Id = 3, Name = "Hard Drive 4TB", price = 20.99m, Description = "enter a desc here"});
                productList.Add(new ProductModel
                    {Id = 4, Name = "Wireless card", price = 55.89m, Description = "enter a desc here"});
                for (int i = 0; i < 100; i++)
                {
                    productList.Add(new Faker<ProductModel>().RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.price, f => f.Random.Decimal(100))
                        .RuleFor(p => p.Description, f => f.Rant.Review()));

                }
            }

            return productList;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
