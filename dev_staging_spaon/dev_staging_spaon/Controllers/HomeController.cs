using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dev_staging_spaon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            if (1 == 1)
            {
                Console.WriteLine("anhYeuEm");
            }
            return View();
        }
    }
}
