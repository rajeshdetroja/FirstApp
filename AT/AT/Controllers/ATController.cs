using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AT.Controllers
{
    public class ATController : Controller
    {
        //
        // GET: /AT/

        public ActionResult Index()
        {
            return View();
        }

        public string AT()
        {
            return "First AT";
        }

    }
}
