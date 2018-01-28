using System.Web;
using System.Web.Mvc;

namespace DATN_ThiBangLaiXe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
