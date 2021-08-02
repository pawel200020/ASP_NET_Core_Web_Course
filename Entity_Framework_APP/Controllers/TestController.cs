using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity_Framework_APP.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestView()
        {
            return View();
        }

        public string Welcome(string Name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode( "hello " + Name +" "+ numTimes);
        }
        public string Welcome2(string Name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("hello " + Name + " ID " + ID);
        }
        public ActionResult ErrorMessage()
        {
            return View();
        }
        public string PrintMessage()
        {
            return "<h1>hello</h1>";
        }
        public string Play()
        {
            return "<h1>hello player</h1>";
        }
    }
}