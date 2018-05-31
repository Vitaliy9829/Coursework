using System.Web;
using System.Web.Mvc;

namespace defender_of_ukraine_day
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
