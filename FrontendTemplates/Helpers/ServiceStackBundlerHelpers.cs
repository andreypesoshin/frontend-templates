using System;
using System.Configuration;
using System.Web.Configuration;
using System.Web.Mvc;
using ServiceStack.Html;

namespace FrontendTemplates.Helpers
{
    /* 
     * Here we have an option on how to seamlessly avoid using ViewBag.BundleOption
     * (previously set in global filter) and use a more convinient way
     */
    public static class ServiceStackBundlerHelpers
    {
        public static BundleOptions GetBundleOption()
        {
            var bundleOptionByAppSetting = GetBundleOptionByAppSetting();

            if (bundleOptionByAppSetting != null)
            {
                return (BundleOptions)bundleOptionByAppSetting;
            }
            else
            {
                return GetBundleOptionByDebugMode();
            }
        }

        public static BundleOptions? GetBundleOptionByAppSetting()
        {
            BundleOptions bundleOption;

            var parsed = Enum.TryParse(ConfigurationManager.AppSettings["BundleOption"], true, out bundleOption);

            if (!parsed)
            {
                return null;
            }

            return bundleOption;
        }

        public static BundleOptions GetBundleOptionByDebugMode()
        {
            CompilationSection compilationSection =
                (CompilationSection)ConfigurationManager.GetSection(@"system.web/compilation");

            return compilationSection.Debug
                ? BundleOptions.Combined
                : BundleOptions.MinifiedAndCombined;
        }

        public static MvcHtmlString CssBundle(this HtmlHelper html, string bundlePath)
        {
            var bundleOption = GetBundleOption();
            return html.RenderCssBundle(bundlePath, bundleOption);
        }

        public static MvcHtmlString JsBundle(this HtmlHelper html, string bundlePath)
        {
            var bundleOption = GetBundleOption();
            return html.RenderJsBundle(bundlePath, bundleOption);
        }
    }
}