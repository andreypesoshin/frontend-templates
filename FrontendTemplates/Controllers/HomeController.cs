using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceStack.Html;

namespace FrontendTemplates.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Demo(string env)
        {
            var bundleOption = BundleOptions.Normal;
            switch (env)
            {
                case "prod":
                    bundleOption = BundleOptions.MinifiedAndCombined;
                    break;
                case "test":
                    bundleOption = BundleOptions.Combined;
                    break;
            }


            return View(bundleOption);
        }
    }
}