using ASP_NET_Core_Web_Development_course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_Core_Web_Development_course.Services
{
    public class HardCodedSampleDataRepositoryCars : ICarDataService
    {
        static List<CarModel> carList = new List<CarModel>();
        public int Delete(CarModel product)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> GetAllProducts()
        {
            carList.Add(new CarModel() { Id = 1, brand = "Opel", dateProduction = DateTime.Now});
            return carList;
        }

        public CarModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(CarModel product)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> SearchProducts()
        {
            throw new NotImplementedException();
        }

        public int Update(CarModel product)
        {
            throw new NotImplementedException();
        }
    }
}
