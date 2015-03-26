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
        public ActionResult Demo()
        {
            // auto-negotiation by parameter specified in Web.config
            var optionParameter = ConfigurationManager.AppSettings["BundleOption"];

            var bundleOption = BundleOptions.Normal;

            Enum.TryParse(ConfigurationManager.AppSettings["BundleOption"], true, out bundleOption);

            return View(bundleOption);
        }

        [HttpGet]
        public ActionResult Demo(string env)
        {
            // negotiation by specified GET parameter

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

            return View(bundleOption);
        }
    }
}