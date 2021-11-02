using ASP_NET_Core_Web_Development_course.Models;
using Basic_Products_APP.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace ASP_NET_Core_Web_Development_course.Controllers
{
    internal class LogActionFiltersAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            UserModel user = (UserModel)((Controller)context.Controller).ViewData.Model;
            MyLogger.GetInstance().Info("Leaving process login");
            MyLogger.GetInstance().Info("User logged in " + user.toString());

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            MyLogger.GetInstance().Info("Entering process login");
        }
    }
}