using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quality_Project.Controllers
{
    public class DesktopController : Controller
    {
        // GET: Desktop
        public ActionResult QMS_Display()
        {
            return View();
        }

        public ActionResult snag_analysis()
        {
            return View();
        }

        public ActionResult SnagTarget()
        {
            return View();
        }

        public ActionResult NonQuality()
        {
            return View();
        }

        public ActionResult Schedule()
        {
            return View();
        }
    }
}