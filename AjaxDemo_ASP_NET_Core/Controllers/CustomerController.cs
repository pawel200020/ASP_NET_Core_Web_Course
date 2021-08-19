using AjaxDemo_ASP_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AjaxDemo_ASP_NET_Core.Controllers
{
    public class CustomerController : Controller
    {
        private List<CustomerModel> customers = new List<CustomerModel>();
        public CustomerController()
        {
            customers.Add(new CustomerModel(0, "John", "Kowalski", 22));
            customers.Add(new CustomerModel(1, "Maria", "Nowak", 33));
            customers.Add(new CustomerModel(2, "Joahim", "Zimny", 45));
            customers.Add(new CustomerModel(3, "Jonasz", "Niski", 67));
        }
        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult ShowOnePerson(int id)
        {
            CustomerModel cust = customers.FirstOrDefault(x => x.Id == id);
            return PartialView(cust);
        }
    }
}
