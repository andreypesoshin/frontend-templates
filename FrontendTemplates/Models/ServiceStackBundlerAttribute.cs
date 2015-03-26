using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceStack.Html;

namespace FrontendTemplates.Models
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class ServiceStackBundlerAttribute : FilterAttribute, IActionFilter
    {
        public ServiceStackBundlerAttribute()
        {
        }


        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // try to negotiate BundleOption with a parameter specified in Web.config
            BundleOptions bundleOption;

            var parsed = Enum.TryParse(ConfigurationManager.AppSettings["BundleOption"], true, out bundleOption);

            if (!parsed)
            {
                // default behavior (if a parameter is not set for some reason)
                bundleOption = BundleOptions.Normal;
            }

            filterContext.Controller.ViewBag.BundleOption = bundleOption;
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }
    }
}