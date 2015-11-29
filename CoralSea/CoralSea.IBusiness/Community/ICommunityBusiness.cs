using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.Community;

namespace CoralSea.IBusiness.Community
{
    public interface ICommunityBusiness
    {
        List<CommunityInfoModel> GetCommunityInfoList(int tagId);

        List<CommunityInfoModel> GetUserCommunityInfoList(int userId);

        List<CommunityInfoModel> GetRecommendCommunityList(int userId);

        List<CommunityMemberModel> GetCommunityMemberList(int communityId);

        CommunityOperationResult CreateCommunity(CommunityInfoModel model);

        CommunityOperationResult UpdateCommunity(int communityId, CommunityInfoModel model);

        CommunityOperationResult AddCommunityMember(CommunityMemberModel model);

        CommunityOperationResult RemoveCommunityMember(CommunityMemberType memberType, int relatedId);

        List<TopicModel> GetTopicList(int communityId);
    }
}
