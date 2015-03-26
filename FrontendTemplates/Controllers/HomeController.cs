using System;
using System.Collections.Generic;
using System.Configuration;
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

        [HttpGet]
        public ActionResult Demo(string env)
        {

            // if the env-parameter is set via GET
            // (otherwise use default behavior inherited from global filter)
            if (env != null)
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

                ViewBag.BundleOption = bundleOption;
            }

            return View(ViewBag.BundleOption);
        }
    }
}