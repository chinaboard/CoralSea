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
        List<CommunityInfoModel> GetUserCommunityInfoList(int userId);

        List<CommunityMemberModel> GetCommunityMemberList(int communityId);

        CommunityOperationResult CreateCommunity(CommunityInfoModel model);

        CommunityOperationResult UpdateCommunity(int communityId, CommunityInfoModel model);

        CommunityOperationResult AddCommunityMember(CommunityMemberModel model);
    }
}
