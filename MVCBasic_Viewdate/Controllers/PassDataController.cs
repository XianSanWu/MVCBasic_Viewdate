using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBasic_Viewdate.Models;
using MVCBasic_Viewdate.ViewModels;

namespace MVCBasic_Viewdate.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassDate
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PassViewData()
        {
            ViewData["Name"] = "San";   //存字串
            ViewData["Age"] = 23;       //存整數
            ViewData["Single"] = true;  //存布林直
            return View();
        }
        public ActionResult PassViewBag()
        {
            ViewBag.Nickname = "Mary";
            ViewBag.Height = 168;
            ViewBag.Weight = 55;
            ViewBag.Married = false;
            return View();
        }
        public ActionResult PassViewModel()
        {
            ViewData["Company"] = "汪星人寵物店";
            ViewBag.Address = "台北市信義區松山路 100 號";
            List<string> Petlist = new List<string>();
            Petlist.Add("狗");
            Petlist.Add("貓");
            Petlist.Add("魚");
            Petlist.Add("鼠");
            Petlist.Add("變色龍");
            // ViewData.Model = petsList;
            return View(Petlist);
        }
        public ActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限，請聯繫客服人員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();
            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }
        public ActionResult PassViewModels()
        {
            PeopleViewModel peopleVM = new PeopleViewModel();
            peopleVM.employees = null;
            peopleVM.friends = null;

            return View(peopleVM);
        }

    }
}