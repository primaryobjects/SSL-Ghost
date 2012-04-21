using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSLGhost.Helpers
{
    public static class Html
    {
        /// <summary>
        /// Determines whether to enable HTTP or HTTPS links. This method is used on views with sensitive forms, to allow disabling HTTPS for development by changing their URL and disabling the RequireHttpsByConfig attribute.
        /// </summary>
        /// <returns>HTTP or HTTPS</returns>
        public static string GetHttpOrHttps(this HtmlHelper helper)
        {
            string protocol = "http://";

            string enableSSL = ConfigurationManager.AppSettings["EnableSSL"];
            if (!string.IsNullOrEmpty(enableSSL) && enableSSL.ToLower() == "true")
            {
                protocol = "https://";
            }

            return protocol;
        }
    }
}