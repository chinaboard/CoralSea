using CoralSea.IBusiness.Community;
using CoralSea.IBusiness.Rank;
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
        
        /// <summary>
        /// 
        /// </summary>
        private IRankLevelBusiness _iRankLevelBusiness = DependenceInjector.GetInstance<IRankLevelBusiness>();

        /// <summary>
        /// 
        /// </summary>
        private ITopicBusiness _iTopicBusiness = DependenceInjector.GetInstance<ITopicBusiness>();

        #endregion

        #region  + Configurations

        private const int DEFAULT_HOST_TOPIC_COUNT = 10;

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            var list = _iTopicBusiness.GetLastHostTopics(CurrentUserInfo.Id, DEFAULT_HOST_TOPIC_COUNT);


            ViewData["CurrentUserInfo"] = CurrentUserInfo;
            ViewData["RankLevel"] = _iRankLevelBusiness.GetRankLevel(CurrentUserInfo.Rank);

            return View(list);
        }

        [HttpGet]
        public ActionResult GuessCommunity()
        {
            

            return View();
        }
    }
}