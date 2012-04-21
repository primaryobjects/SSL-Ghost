using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SSLGhost.Attributes;
using SSLGhost.Types;

namespace SSLGhost.Controllers
{
    public class GatewayController : BaseController
    {
        [RequireHttpsByConfig, AllowAnonymous]
        public ActionResult Index()
        {
            return View(new Ghost());
        }

        /// <summary>
        /// Login
        /// </summary>
        [RequireHttpsByConfig, AllowAnonymous, HttpPost]
        public ActionResult Index(Ghost user, string returnUrl)
        {
            // Validate the model.
            if (ModelState.IsValid)
            {
                // Validate the user login.
                if (Membership.ValidateUser(user.Name, user.SkeletonKey))
                {
                    // Create the authentication ticket.
                    FormsAuthentication.SetAuthCookie(user.Name, false);

                    // Redirect to the secure area.
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "graveyard");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You must supply the correct skeleton key to enter the graveyard.");
                }
            }

            return View(user);
        }
    }
}
