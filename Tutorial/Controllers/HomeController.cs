using Tutorial.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tutorial.Controllers
{
    public class HomeController : Controller
    {
        [Authorize( Roles = "superadmin" )]
        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult Index()
        {
            ApplicationDb db = new ApplicationDb();
            var Customers = db.Customers.ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}