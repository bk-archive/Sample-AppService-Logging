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
            //System.Diagnostics.Trace.TraceInformation("This is an Info Message");

            var rand = new Random();
            int r = rand.Next(5);

            System.Diagnostics.Trace.TraceInformation("Index = "  + r );

            if (r <= 3)
            {
                throw new Exception();
            }
            
            return View();
        }

        public ActionResult About()
        {
            System.Diagnostics.Trace.TraceWarning("This is a Warning");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            System.Diagnostics.Trace.TraceError("This is an Error");
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}