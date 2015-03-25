using System.Web.Mvc;
using System.Web.WebPages;

namespace FrontendTemplates.Models
{
    public abstract class CustomWebPage : WebViewPage
    {

    }

    public abstract class CustomWebPage<T>: WebViewPage<T>
    {

    }
}