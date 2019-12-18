using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD.HtmlHelpMeth
{
    public  static  class ImgHelp
    {
        public static MvcHtmlString Image(this HtmlHelper herper,string src,string alt)
        {
            var urlHelper = new UrlHelper(herper.ViewContext.RequestContext);
            TagBuilder builder = new TagBuilder("img");
            builder.MergeAttribute("src", urlHelper.Content(src));
            builder.MergeAttribute("alt", alt);
            builder.ToString(TagRenderMode.SelfClosing);
            return MvcHtmlString.Create(builder.ToString());
        }
        public static string Truncare(this HtmlHelper herper, string mu, int lengh)
        {
            if (mu.Length <=lengh)
            {
                return mu;
            }
            else
            {
                var w = mu.Substring(0, lengh)+"...";
                return w;
            }
        }

    }
}