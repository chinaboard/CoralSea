using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoralSea.Web.Controllers
{
    /// <summary>
    /// 登录后的主页，以及圈子页面
    /// </summary>
    public class CommunityController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GuessCommunity()
        {
            return View();
        }
    }
}