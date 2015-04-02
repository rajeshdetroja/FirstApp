using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Publish_NuGet.Controllers
{
    public class DispalyController : Controller
    {
        //
        // GET: /Dispaly/

        public ActionResult Index()
        {
            return View();
        }

        public string Display()
        {
            return "hello... ";
        }
    }
}
