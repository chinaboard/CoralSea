using CoralSea.Common;
using CoralSea.Model.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.FakeData.Community
{
    public class FakeTopicReply : TopicReplyModel
    {
        public FakeTopicReply(int topicId, int replyId)
        {
            ReplyId = replyId;
            TopicId = topicId;
            ReplyMemberId = RandomHelper.Next(10000);
            ReplyMemberName = FakeName.MakeFakeUserName();
            ReplyMemberImage = FakeImage.MakeFakeImage();
            ReplyTime = RandomHelper.Time();
            Content = FakeContent.MakeContent();
        }
    }
}
