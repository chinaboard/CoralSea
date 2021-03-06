﻿using CoralSea.Common;
using CoralSea.Model.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.FakeData.Community
{
    public class FakeTopic : TopicModel
    {
        public FakeTopic(int topicId)
        {
            TopicId = topicId;
            CreatorId = RandomHelper.Next(10000);
            TopicTitle = FakeContent.MakeTitle();
            ViewCount = RandomHelper.Next(32423);
            for (int i = 0; i < RandomHelper.Next(2, 10); i++)
                ReplyList.Add(new FakeTopicReply(topicId, RandomHelper.Next(10000)));
            CreateTime = RandomHelper.Time();
            LastUpdateTime = RandomHelper.Time();
            Owner = new FakeCommunityInfo();
            Content = FakeContent.MakeContent();
        }
    }
}
