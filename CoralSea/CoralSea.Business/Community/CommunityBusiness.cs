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
    public class CommunityBusiness : ICommunityBusiness
    {
        public CommunityOperationResult AddCommunityMember(CommunityMemberModel model)
        {
            return new CommunityOperationResult() { IsSucceed = RandomHelper.Bool() };
        }

        public CommunityOperationResult CreateCommunity(CommunityInfoModel model)
        {
            return new CommunityOperationResult() { IsSucceed = RandomHelper.Bool() };
        }

        public List<CommunityMemberModel> GetCommunityMemberList(int communityId)
        {
            var list = new List<CommunityMemberModel>();
            var count = RandomHelper.Next(100);
            while (count-- > 0)
            {
                list.Add(new FakeCommunityMember());
            }
            return list;
        }

        public List<TopicModel> GetTopicList(int communityId)
        {
            var list = new List<TopicModel>();
            var count = RandomHelper.Next(100);
            while (count-- > 0)
            {
                list.Add(new FakeTopic(RandomHelper.Next(10090)));
            }
            return list;
        }

        public List<CommunityInfoModel> GetUserCommunityInfoList(int userId)
        {
            var list = new List<CommunityInfoModel>();
            var count = RandomHelper.Next(100);
            while (count-- > 0)
            {
                list.Add(new FakeCommunityInfo());
            }
            return list;
        }

        public CommunityOperationResult RemoveCommunityMember(CommunityMemberType memberType, int relatedId)
        {
            return new CommunityOperationResult() { IsSucceed = RandomHelper.Bool() };
        }

        public CommunityOperationResult UpdateCommunity(int communityId, CommunityInfoModel model)
        {
            return new CommunityOperationResult() { IsSucceed = RandomHelper.Bool() };
        }
    }
}
