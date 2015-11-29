using CoralSea.IBusiness.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoralSea.Injector;

namespace CoralSea.Web.Controllers
{
    public class TopicController : BaseController
    {
        #region  + Services

        /// <summary>
        /// 
        /// </summary>
        private ITopicBusiness _iTopicBusiness = DependenceInjector.GetInstance<ITopicBusiness>();

        #endregion

        [HttpGet]
        public ActionResult Index(int topicId = 0)
        {
            var topicEntity = _iTopicBusiness.GetTopic(topicId);

            var tempClone = topicEntity.ReplyList.OrderByDescending(m => m.ReplyTime).ToList();

            topicEntity.ReplyList.Clear();
            topicEntity.ReplyList.AddRange(tempClone);

            return View(topicEntity);
        }
    }
}