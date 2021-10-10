using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_Core_Web_Development_course.Models
{
    public class ProductModelDTO
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DisplayName("Cost to costumer")]
        [DataType(DataType.Currency)]
        public decimal price { get; set; }
        [DisplayName("what you get")]
        public string PriceString { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public decimal Tax { get; set; }
        public ProductModelDTO(int id, string name, decimal price, string description)
        {
            this.Id = id;
            this.Name = name;
            this.price = price;
            this.Description = description;

            PriceString = string.Format("{0:C}", price);
            ShortDescription = description.Length <= 25 ? description : description.Substring(0, 25);
            Tax = price * 0.23M;

        }
        public ProductModelDTO(ProductModel product)
        {
            this.Id = product.Id;
            this.Name = product.Name;
            this.price = product.price;
            this.Description = product.Description;

            PriceString = string.Format("{0:C}", price);
            ShortDescription = product.Description.Length <= 25 ? product.Description : product.Description.Substring(0, 25);
            Tax = price * 0.23M;

        }
    }
}
