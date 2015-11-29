using CoralSea.IBusiness.Community;
using CoralSea.Injector;
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
    public class CommunityController : BaseController
    {
        #region  + Services

        /// <summary>
        /// 
        /// </summary>
        private ICommunityBusiness _iCommunityBusiness = DependenceInjector.GetInstance<ICommunityBusiness>();

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            var list = _iCommunityBusiness.GetUserCommunityInfoList(CurrentUserInfo.Id);

            return View();
        }

        [HttpGet]
        public ActionResult GuessCommunity()
        {
            return View();
        }
    }
}