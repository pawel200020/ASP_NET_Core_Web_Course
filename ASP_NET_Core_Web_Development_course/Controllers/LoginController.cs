using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_NET_Core_Web_Development_course.Models;

namespace ASP_NET_Core_Web_Development_course.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            if (userModel.UserName == "Bill" && userModel.Password == "bigbuck")
            {
                return View("LoginSuccess",userModel);
            }
            else
            {
                return View("LoginFailure", userModel);
            }
           
        }
    }
}
