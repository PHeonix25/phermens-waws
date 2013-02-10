using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WAWSTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            View().ViewBag.RobyParameter = "My name is Roby"; // Not the "right" way of doing things.
            return View();
        }

    }
}
