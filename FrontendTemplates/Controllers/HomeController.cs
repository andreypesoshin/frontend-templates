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
            BundleOptions bundleOption;

            // first try negotiation by specified GET parameter
            switch (env)
            {
                case "prod":
                    bundleOption = BundleOptions.MinifiedAndCombined;
                    break;
                case "test":
                    bundleOption = BundleOptions.Combined;
                    break;
                case "dev":
                    bundleOption = BundleOptions.Normal;
                    break;
                default:
                    // auto-negotiation by parameter specified in Web.config
                    Enum.TryParse(ConfigurationManager.AppSettings["BundleOption"], true, out bundleOption);
                    break;
            }

            ViewBag.BundleOption = bundleOption;

            return View(bundleOption);
        }
    }
}