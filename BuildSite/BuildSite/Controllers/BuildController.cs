using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildSite.Controllers
{
    public class BuildController : Controller
    {
        public ActionResult Builder()
        {
            return View();
        }

        public ActionResult Build()
        {
            return View();
        }
    }
}