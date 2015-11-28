using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoralSea.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult NewBaseInfo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBaseInfo(string phoneNumer,string microAccount, List<string> interest)
        {
            return RedirectToAction("TaskList","TaskManager",null);
        }
        
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string identify,string jobNumber)
        {
            return RedirectToAction("NewBaseInfo", "Home", null);
        }
    }
}