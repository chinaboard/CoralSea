using CoralSea.Common;
using CoralSea.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.FakeData.User
{
    public class FakeUserInfo : UserInfoModel
    {



        public FakeUserInfo(int id)
        {
            Id = id;
            JobNumber = RandomHelper.Next().ToString();
            Name = FakeName.MakeFakeName();
            EntryTime = RandomHelper.Bool() ? DateTime.Now.Subtract(TimeSpan.FromDays(RandomHelper.Next(2000))) : DateTime.Now.Subtract(TimeSpan.FromHours(RandomHelper.Next(1000)));
            Rank = (int)DateTime.Now.Subtract(EntryTime).TotalDays * 2 + RandomHelper.Next(1000);
            Sex = RandomHelper.Bool() ? "男" : "女";
            LastLoginTime = DateTime.Now;
            NickName = FakeName.MakeFakeName();
            GroupName = FakeName.MakeFakeGroupName();
            Interesting.AddRange(new List<string>() { "耍帅", "睡觉", "撸代码" });
            Signature = "yooooooooooo";
            Image = FakeImage.MakeFakeImage();
        }

    }
}
