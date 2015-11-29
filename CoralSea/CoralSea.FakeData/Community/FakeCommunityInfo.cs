using CoralSea.Common;
using CoralSea.Model.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.FakeData.Community
{
    public class FakeCommunityInfo : CommunityInfoModel
    {
        public FakeCommunityInfo()
        {
            CommunityId = RandomHelper.Next(23432);
            ParentId = RandomHelper.Next(234);
            Name = FakeName.MakeFakeName();
            Image = FakeImage.MakeFakeImage();
            MasterId = RandomHelper.Next(23432);
            CreateTime = RandomHelper.Time();
            LastActivityTime = RandomHelper.Time();
            CloseTime = RandomHelper.Bool() ? RandomHelper.Time() : DateTime.MaxValue;
        }
    }
}
