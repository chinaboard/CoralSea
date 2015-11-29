using CoralSea.Common;
using CoralSea.FakeData.User;
using CoralSea.IBusiness;
using CoralSea.Injector;
using CoralSea.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoralSea.Web.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ISecurityBusinesscs securityBusinesscs = DependenceInjector.GetInstance<ISecurityBusinesscs>();

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
        public ActionResult NewBaseInfo(string phoneNumer, string microAccount, List<string> interest)
        {
            return RedirectToAction("TaskList", "TaskManager", null);
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string identify, string jobNumber)
        {
            UserLoginModel model = new UserLoginModel
            {
                IdNumber = identify,
                LoginType = LoginType.Novice,
                JobNumber = jobNumber
            };

            var result = securityBusinesscs.UserVerify(model);

            Session["UserInfo"] = new FakeUserInfo(result.UserId);

            return RedirectToAction("IndexPic", "Home", null);
        }

        public ActionResult IndexPic()
        {
            return View();
        }
    }
}