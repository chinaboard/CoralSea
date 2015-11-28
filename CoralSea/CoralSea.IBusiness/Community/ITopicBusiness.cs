using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.Community;

namespace CoralSea.IBusiness.Community
{
    public interface ITopicBusiness
    {
        TopicModel GetTopic(int topicId);

        TopicOperationResult CreateTopic(TopicModel model);

        TopicOperationResult UpdateTopic(int topicId, TopicModel model);

        TopicOperationResult ChangeTopicStatus(int topicId, TopicStatus status);

        TopicOperationResult ReplyTopic(int topicId, TopicReplyModel model);

        List<TopicModel> GetLastHostTopics(int userId, int topK);
    }
}
