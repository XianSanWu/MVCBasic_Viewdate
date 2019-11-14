using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic_Viewdate.Controllers
{
    public class MacController : Controller
    {
        // GET: Mac
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MacPage()
        {
            return View();
        }
    }
}