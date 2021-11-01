using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_NET_Core_Web_Development_course.Models;
using ASP_NET_Core_Web_Development_course.Services;
using Microsoft.Extensions.Logging;
using NLog;

namespace ASP_NET_Core_Web_Development_course.Controllers
{
    public class LoginController : Controller
    {
        private static Logger logger = LogManager.GetLogger("RegisterLoginAppRule");
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            logger.Info("Processing loging attepted");
            logger.Info(userModel.toString);

            SecurityService securityService = new SecurityService();
            if (securityService.IsValid(userModel))
            {
                logger.Info("Login Success");
                return View("LoginSuccess",userModel);
            }
            else
            {
                logger.Warn("Login failure");
                return View("LoginFailure", userModel);
            }
           
        }
    }
}
