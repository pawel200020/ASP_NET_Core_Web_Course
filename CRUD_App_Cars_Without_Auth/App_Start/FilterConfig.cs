using System.Web;
using System.Web.Mvc;

namespace CRUD_App_Cars_Without_Auth
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
