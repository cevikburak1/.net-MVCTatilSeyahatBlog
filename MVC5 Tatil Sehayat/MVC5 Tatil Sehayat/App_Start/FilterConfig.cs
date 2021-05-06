using System.Web;
using System.Web.Mvc;

namespace MVC5_Tatil_Sehayat
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
