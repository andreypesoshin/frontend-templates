using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceStack.Html;

namespace FrontendTemplates.Models
{
    /* 
     * Here we have an option on how to seamlessly avoid using ViewBag.BundleOption
     * (previously set in global filter) and use a more convinient way
     */
    public static class ServiceStackBundlerExtensions
    {
        public static MvcHtmlString CustomRenderCssBundle(this HtmlHelper html, string bundlePath)
        {
            return html.RenderCssBundle(bundlePath, (BundleOptions)html.ViewBag.BundleOption);
        }

        public static MvcHtmlString CustomRenderJsBundle(this HtmlHelper html, string bundlePath)
        {
            return html.RenderJsBundle(bundlePath, (BundleOptions)html.ViewBag.BundleOption);
        }
    }
}