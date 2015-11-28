using CoralSea.IBusiness.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.Community;
using CoralSea.Common;
using CoralSea.FakeData.Community;

namespace CoralSea.Business.Community
{
    public class TopicBusiness : ITopicBusiness
    {
        public TopicOperationResult ChangeTopicStatus(int topicId, TopicStatus status)
        {
            return new TopicOperationResult() { IsSucceed = RandomHelper.Bool(), ErrorMessage = "gaga" };
        }

        public TopicOperationResult CreateTopic(TopicModel model)
        {
            return new TopicOperationResult() { IsSucceed = RandomHelper.Bool(), ErrorMessage = "gaga" };
        }

        public List<TopicModel> GetLastHostTopics(int userId, int topK)
        {
            throw new NotImplementedException();
        }

        public TopicModel GetTopic(int topicId)
        {
            return new FakeTopic(topicId);
        }

        public TopicOperationResult ReplyTopic(int topicId, TopicReplyModel model)
        {
            return new TopicOperationResult() { IsSucceed = RandomHelper.Bool(), ErrorMessage = "gaga" };
        }

        public TopicOperationResult UpdateTopic(int topicId, TopicModel model)
        {
            return new TopicOperationResult() { IsSucceed = RandomHelper.Bool(), ErrorMessage = "gaga" };
        }
    }
}
