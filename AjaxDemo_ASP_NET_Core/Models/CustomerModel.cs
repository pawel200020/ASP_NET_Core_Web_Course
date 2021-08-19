using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxDemo_ASP_NET_Core.Models
{
    public class CustomerModel
    {
        public CustomerModel(int id, string name, string lastname, int age)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastname;
            this.Age = age;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
