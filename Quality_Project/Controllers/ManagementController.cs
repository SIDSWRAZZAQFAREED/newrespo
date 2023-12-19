using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quality_Project.Controllers
{
    public class ManagementController : Controller
    {
        // GET: Management
        public ActionResult User()
        {
            return View();
        }
        public ActionResult Security()
        {

            return View();
        }
    }
}