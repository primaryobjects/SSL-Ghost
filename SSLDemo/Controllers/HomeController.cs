using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSLDemo.Attributes;

namespace SSLDemo.Controllers
{
    public class HomeController : BaseController
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }
}
