using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Diversify.Umbraco.Web.Model
{
    public static class HtmlExtensions
    {

        public static IHtmlString Breadcrumb(this HtmlHelper helper, IPublishedContent thisPage)
        {
            StringBuilder breadcrumb = new StringBuilder();

            IEnumerable<IPublishedContent> ancestors = thisPage.Ancestors().Reverse();

            foreach (IPublishedContent page in ancestors)
            {
                breadcrumb.Append($"<a href=\"{page.Url}\">{page.Name}</a>");
            }

            breadcrumb.Append($"<span>{thisPage.Name}</span>");

            return MvcHtmlString.Create(breadcrumb.ToString());
        }
     

    }
}