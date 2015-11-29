using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CoralSea.IBusiness;
using CoralSea.Injector;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using CoralSea.Web.Models;
using CoralSea.Model;
using CoralSea.FakeData.User;
using CoralSea.Common;

namespace CoralSea.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private static readonly ISecurityBusinesscs securityBusinesscs = DependenceInjector.GetInstance<ISecurityBusinesscs>();

        public AccountController()
        {
        }


        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl, string jobNumber, string password)
        {
            ViewBag.ReturnUrl = returnUrl;

            UserLoginModel model = new UserLoginModel
            {
                Password = password,
                LoginType = LoginType.Veteran,
                JobNumber = jobNumber
            };

            Session["UserInfo"] = new FakeUserInfo(RandomHelper.Next(2345));

            securityBusinesscs.UserVerify(model);

            if (returnUrl != null && returnUrl.Contains("Register"))
            {
                return RedirectToAction("Register", "Home");
            }
            if (!string.IsNullOrWhiteSpace(jobNumber) && !string.IsNullOrWhiteSpace(password))
            {
                return RedirectToAction("Index", "Community", null);
            }
            return View();
        }
        
    }
}