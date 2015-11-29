using CoralSea.Common;
using CoralSea.Model.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.FakeData.Community
{
    public class FakeCommunityMember : CommunityMemberModel
    {
        public FakeCommunityMember()
        {
            RelatedId = RandomHelper.Next(10000);
            MemberName = FakeName.MakeFakeName();
            Image = FakeImage.MakeFakeImage();
            JoinTime = RandomHelper.Time();
        }

    }
}
