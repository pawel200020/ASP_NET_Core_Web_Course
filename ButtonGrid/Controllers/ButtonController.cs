using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public IActionResult HandleButtonClick(string number)
        {
            int num = int.Parse(number);
            buttons.ElementAt(num).State = (buttons.ElementAt(num).State + 1)%4;
            return View("Index", buttons);
        }
    }
}
