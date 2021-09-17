using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ButtonGrid.Controllers
{
    public class ButtonController : Controller
    {
        static List<ButtonModel> buttons = new List<ButtonModel>();
        private Random random = new Random();
        private const int SIZE = 25;
        public IActionResult Index()
        {
            if (buttons.Count < SIZE)
            {
                for (int i = 0; i < SIZE; i++)
                {
                    buttons.Add(new ButtonModel(i, random.Next(4)));

                }
            }
            
            
            return View("Index",buttons);
        }

        public IActionResult HandleButtonClick(string ButtonNumber)
        {
            int num = int.Parse(ButtonNumber);
            buttons.ElementAt(num).State = (buttons.ElementAt(num).State + 1)%4;
            return View("Index", buttons);
        }

        public IActionResult showOneButton(int ButtonNumber)
        {
            buttons.ElementAt(ButtonNumber).State = (buttons.ElementAt(ButtonNumber).State + 1) % 4;
            string buttonString = RenderRazorViewToString(this, "showOneButton", buttons.ElementAt(ButtonNumber));
            //zrzucamy widok do stringa bo chcemy updatować 2 elementy na stronie, które złączamy w package i wysysłamy do pliku json
            bool isWin = true;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons.ElementAt(i).State != buttons.ElementAt(0).State)
                {
                    isWin = false;
                }
            }

            string messageString="";
            if (isWin)
            {
                messageString = "<p>Congratulations. All buttons match </p>";
            }
            else
            {
                messageString = "<p>Match all buttons </p>";
            }

            var package = new { part1 = buttonString, part2 = messageString };
            return Json(package);
            
            return PartialView(buttons.ElementAt(ButtonNumber));
        }

        public static string RenderRazorViewToString(Controller controller, string viewName, object model = null)
        {
            controller.ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                IViewEngine viewEngine =
                    controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as
                        ICompositeViewEngine;
                ViewEngineResult viewResult = viewEngine.FindView(controller.ControllerContext, viewName, false);

                ViewContext viewContext = new ViewContext(
                    controller.ControllerContext,
                    viewResult.View,
                    controller.ViewData,
                    controller.TempData,
                    sw,
                    new HtmlHelperOptions()
                );
                viewResult.View.RenderAsync(viewContext);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}
