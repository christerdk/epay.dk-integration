using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace epay.dk.Controllers
{
    public class OverlayController : Controller
    {
        //
        // GET: /Overlay/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult accepturl()
        {
            return View("WriteAll");
        }

        public ActionResult cancelurl()
        {
            return View("WriteAll");
        }

        public ActionResult callbackurl()
        {
            return View();
        }

    }
}
