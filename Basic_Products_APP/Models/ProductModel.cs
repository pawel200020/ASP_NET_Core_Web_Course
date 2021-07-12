using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_Core_Web_Development_course.Models
{
    public class ProductModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DisplayName("Cost to costumer")]
        [DataType(DataType.Currency)]
        public decimal price { get; set; }
        [DisplayName("what you get")]
        public string Description { get; set; }
    }
}
