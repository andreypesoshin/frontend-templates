using System.Web;
using System.Web.Mvc;
using FrontendTemplates.Models;

namespace FrontendTemplates
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ServiceStackBundlerAttribute());
        }
    }
}
