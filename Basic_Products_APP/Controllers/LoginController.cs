using Microsoft.AspNetCore.Mvc;
using ASP_NET_Core_Web_Development_course.Models;
using ASP_NET_Core_Web_Development_course.Services;
using Microsoft.AspNetCore.Http;

namespace ASP_NET_Core_Web_Development_course.Controllers
{
    public class LoginController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [CustomAuthorization]
        
        public IActionResult PrivateSection()
        {
            return Content("Protected method");
        }
        [LogActionFilters]
        public IActionResult ProcessLogin(UserModel userModel)
        {
            //MyLogger.GetInstance().Info("Processing loging attepted");
            //MyLogger.GetInstance().Info(userModel.toString());

            SecurityService securityService = new SecurityService();
            if (securityService.IsValid(userModel))
            {
                HttpContext.Session.SetString("username", userModel.UserName);
                //MyLogger.GetInstance().Info("Login Success");
                return View("LoginSuccess",userModel);
            }
            else
            {
                HttpContext.Session.Remove("username");
                //MyLogger.GetInstance().Warning("Login failure");
                return View("LoginFailure", userModel);
            }
           
        }
    }
}
