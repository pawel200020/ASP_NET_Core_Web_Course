using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Tree;

using Entity_Framework_APP.Models;

namespace  Entity_Framework_APP.Controllers
{
    public class CarController : Controller
    {
        private ApplicationDbContext context;
        public CarController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        // GET: Car
        public ActionResult Index()
        {
            List<Car> cars = context.cars.ToList();
            return View("Index", cars);
        }

        public ActionResult Details(int id)
        {
            Car car = context.cars.SingleOrDefault(c => c.Id == id);
            return View("Details",car);
        }

        public ActionResult Create()
        {

            return View("CarForm",new Car());
        }

        public ActionResult Edit(int id)
        {
            Car car = context.cars.SingleOrDefault(c => c.Id == id);
            return View("CarForm",car);
        }
        public ActionResult ProcessCreate(Car carmodel)
        {
            Car car = context.cars.SingleOrDefault(c => c.Id == carmodel.Id);
            if (car != null)
            {
                car.Carm = carmodel.Carm;
                car.Origin = carmodel.Origin;
                car.Acceleration = carmodel.Acceleration;
                car.Cylinders = carmodel.Cylinders;
                car.Displacement = carmodel.Displacement;
                car.Horsepower = carmodel.Horsepower;
                car.MPG = carmodel.MPG;
                car.Weight = carmodel.Weight;
                car.Model = carmodel.Model;
            }
            else
            {
                context.cars.Add(carmodel);
            }
            context.SaveChanges();
            return View("Details",carmodel);
        }
        public ActionResult Delete(int id)
        {
            Car car = context.cars.SingleOrDefault(c => c.Id == id);
            context.Entry(car).State = EntityState.Deleted;
            context.SaveChanges();
            return Redirect("/Car/Index");
        }

        public ActionResult SearchForm()
        {
            return View("SearchForm");
        }

        public ActionResult SeachForName(string searchPhrase)
        {
            var cars = from c in context.cars where c.Carm.Contains(searchPhrase) select c;
            return View("Index",cars);
        }
        public ActionResult SearchForCountry(string searchPhrase)
        {
            var cars = from c in context.cars where c.Origin.Contains(searchPhrase) select c;
            return View("Index", cars);
        }
    }
}