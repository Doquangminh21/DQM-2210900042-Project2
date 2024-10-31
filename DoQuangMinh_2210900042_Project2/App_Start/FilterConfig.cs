using System.Web;
using System.Web.Mvc;

namespace DoQuangMinh_2210900042_Project2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
