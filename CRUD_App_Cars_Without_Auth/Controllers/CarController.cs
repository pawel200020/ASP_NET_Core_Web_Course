using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Tree;
using CRUD_App_Cars_Without_Auth.Controllers.Data;
using CRUD_App_Cars_Without_Auth.Models;

namespace CRUD_App_Cars_Without_Auth.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            List<Car> cars = new List<Car>();
            CarDAO carDAO = new CarDAO();
            cars = carDAO.FetchAll();
            return View("Index", cars);
        }

        public ActionResult Details(int id)
        {
            Car car = new Car();
            CarDAO carDao = new CarDAO();
            car = carDao.FetchOne(id); 
            return View("Details", car);
        }

        public ActionResult Create()
        {

            return View("CarForm");
        }

        public ActionResult Edit(int id)
        {
            Car car = new Car();
            CarDAO carDao = new CarDAO();
            car = carDao.FetchOne(id);
            return View("CarForm", car);
        }
        public ActionResult ProcessCreate(Car carmodel)
        {
            CarDAO carDao = new CarDAO();
            int NewID = carDao.CreateOrUpdate(carmodel);
            return View("Details",carmodel);
        }
        public ActionResult Delete(int id)
        {
            CarDAO carDao = new CarDAO();
            carDao.Delete(id);
            List<Car> cars = carDao.FetchAll();
            return View("Index",cars);
        }

        public ActionResult SearchForm()
        {
            return View("SearchForm");
        }

        public ActionResult SeachForName(string searchPhrase)
        {
            CarDAO carDao = new CarDAO();
            List<Car> cars = carDao.SeachForName(searchPhrase);
            return View("Index",cars);
        }
        public ActionResult SeachForCountry(string searchPhrase)
        {
            CarDAO carDao = new CarDAO();
            List<Car> cars = carDao.SearchForCountry(searchPhrase);
            return View("Index", cars);
        }
    }
}