using CoralSea.Common;
using CoralSea.Model.Community;
using CoralSea.Model.Tag;
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
            ParentId = RandomHelper.Bool() ? RandomHelper.Next(234) : 0;
            ParentName = ParentId > 0 ? FakeName.MakeFakeGroupName() : "";
            Name = FakeName.MakeFakeName();
            Image = FakeImage.MakeFakeImage();
            MasterId = RandomHelper.Next(23432);
            MemberCount = RandomHelper.Next(546);
            CreateTime = RandomHelper.Time();
            LastActivityTime = RandomHelper.Time();
            CloseTime = RandomHelper.Bool() ? RandomHelper.Time() : DateTime.MaxValue;

            int tagCount = RandomHelper.Next(10);
            for(int i = 0; i < tagCount; i++)
            {
                Tags.Add(new TagModel());
            }
        }
    }
}
