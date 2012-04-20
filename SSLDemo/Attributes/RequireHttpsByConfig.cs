using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace SSLDemo.Attributes
{
    public class RequireHttpsByConfig : RequireHttpsAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (ConfigurationManager.AppSettings["EnableSSL"].ToLower() != "true")
            {
                // HTTPS is not enabled in the web.config. Ignore requiring it.
                return;
            }
            else
            {
                base.OnAuthorization(filterContext);
            }
        }
    }
}
