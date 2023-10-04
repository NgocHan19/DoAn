using System.Web;
using System.Web.Mvc;

namespace ĐồÁn_LT_Bookstores
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
