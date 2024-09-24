using System.Web;
using System.Web.Mvc;

namespace _23DH101826_TRananhduc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
