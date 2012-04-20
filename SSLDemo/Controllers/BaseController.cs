using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSLDemo.Attributes;

namespace SSLDemo.Controllers
{
    [ExitHttpsIfNotRequiredAttribute]
    public abstract class BaseController : Controller
    {
    }
}
