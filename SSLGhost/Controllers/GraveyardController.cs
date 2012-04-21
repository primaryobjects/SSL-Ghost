using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SSLGhost.Attributes;

namespace SSLGhost.Controllers
{
    public class GraveyardController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Logout
        /// </summary>
        public ActionResult Exorcise()
        {
            // Delete the ghost details from cache.
            HttpRuntime.Cache.Remove(User.Identity.Name);

            // Delete the authentication ticket and sign out.
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }
    }
}
