﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Publish.Controllers
{
    public class DisplayController : Controller
    {
        //
        // GET: /Display/

        public ActionResult Index()
        {
            return View();
        }

        public string Display()
        {
            return "Hello Good Morning";
        }
    }
}
