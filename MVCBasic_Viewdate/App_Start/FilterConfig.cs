using System.Web;
using System.Web.Mvc;

namespace MVCBasic_Viewdate
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
