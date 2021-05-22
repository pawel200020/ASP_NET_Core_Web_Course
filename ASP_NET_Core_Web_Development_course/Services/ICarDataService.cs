using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_NET_Core_Web_Development_course.Models;

namespace ASP_NET_Core_Web_Development_course.Services
{
    interface ICarDataService
    {
        List<CarModel> GetAllProducts();
        List<CarModel> SearchProducts();
        CarModel GetProductById(int id);
        int Insert(CarModel product);
        int Delete(CarModel product);
        int Update(CarModel product);
    }
}
