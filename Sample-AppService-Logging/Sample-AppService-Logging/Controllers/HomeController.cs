using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_AppService_Logging.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Diagnostics.Trace.TraceInformation("Index Page");
            return View();
        }

        public ActionResult About()
        {
            System.Diagnostics.Trace.TraceInformation("About Page");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            System.Diagnostics.Trace.TraceInformation("Contact Page");
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}