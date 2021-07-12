using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_NET_Core_Web_Development_course.Models;
using System.Data.SqlClient;

namespace ASP_NET_Core_Web_Development_course.Services
{
    public class SecurityService
    {
        private List<UserModel> knownUsers = new List<UserModel>();
        //ctor to konstruktor
        public SecurityService()
        {
            knownUsers.Add(new UserModel {Id=0, UserName = "Bill", Password = "bigbucks"});
            knownUsers.Add(new UserModel { Id = 1, UserName = "John", Password = "absolut" });
            knownUsers.Add(new UserModel { Id = 2, UserName = "Elon", Password = "boomer" });
        }

        public bool IsValid(UserModel user)
        {
            return knownUsers.Any(x => x.UserName == user.UserName && x.Password==user.Password);
        }
    }
}
