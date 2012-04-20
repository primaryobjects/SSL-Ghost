using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSLDemo.Attributes;
using SSLDemo.Types;

namespace SSLDemo.Controllers
{
    public class GhostController : Controller
    {
        /// <summary>
        /// This method must use JSONP in order to communicate from http to https. JSONP requires GET (does not support POST), so we must leave both protocols available on this method.
        /// </summary>
        [RequireHttpsByConfig, JsonpFilter]
        public JsonResult Haunt(HauntTarget hauntTarget)
        {
            string status = "";

            // Validate the model.
            if (ModelState.IsValid)
            {
                if (hauntTarget.DaysToHaunt > 3)
                {
                    status = "You're not powerful enough yet. Try less days.";
                }
                else
                {
                    status = "OK";
                }
            }

            return Json(new { Status = status, Name = hauntTarget.HumanName, Days = hauntTarget.DaysToHaunt });
        }
    }
}
