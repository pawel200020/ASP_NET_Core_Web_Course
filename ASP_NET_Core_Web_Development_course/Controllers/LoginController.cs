using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_NET_Core_Web_Development_course.Models;
using ASP_NET_Core_Web_Development_course.Services;

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
            SecurityService securityService = new SecurityService();
            if (securityService.IsValid(userModel))
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
