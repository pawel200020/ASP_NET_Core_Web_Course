using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity_Framework_APP.Models;

namespace Entity_Framework_APP.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public string Test()
        {
            return "dupa.exe";
        }

        public string Login(UserModel user)
        {
            return "Result " + user.Username + " " + user.Password;
        }
    }
}