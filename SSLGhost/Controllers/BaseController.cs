using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSLGhost.Attributes;

namespace SSLGhost.Controllers
{
    [ExitHttpsIfNotRequiredAttribute]
    public abstract class BaseController : Controller
    {
    }
}
