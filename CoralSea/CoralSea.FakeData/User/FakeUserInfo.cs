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


        static List<string> _picurlList = new List<string>() {
            "http://img3.douban.com/icon/u48750150-75.jpg",
            "http://img3.douban.com/icon/u137751255-1.jpg",
            "http://img3.douban.com/icon/u61110940-5.jpg",
            "http://img3.douban.com/icon/u122642569-3.jpg",
            "http://img3.douban.com/icon/u40970571-2.jpg",
            "http://img3.douban.com/icon/u97935041-12.jpg",
            "http://img3.douban.com/icon/u138265730-1.jpg",
            "http://img3.douban.com/icon/u54746565-4.jpg",
            "http://img4.douban.com/icon/u53807409-6.jpg",
            "http://img4.douban.com/icon/u84162221-8.jpg",
            "http://img3.douban.com/icon/u55696089-21.jpg",
            "http://img3.douban.com/icon/u33481086-25.jpg",
            "http://img3.douban.com/icon/u124842466-5.jpg",
            "http://img3.douban.com/icon/u50334755-4.jpg",
            "http://img3.douban.com/icon/u51495232-10.jpg",
            "http://img3.douban.com/icon/u136941262-2.jpg",
            "http://img3.douban.com/icon/u61465631-21.jpg",
            "http://img3.douban.com/icon/u33064327-10.jpg",
            "http://img3.douban.com/icon/u72902788-1.jpg",
            "http://img3.douban.com/icon/u88070849-3.jpg",
            "http://img4.doubanio.com/icon/u55408389-9.jpg",
            "http://img3.douban.com/icon/u130597398-2.jpg",
            "http://img4.douban.com/icon/u125696802-17.jpg",
            "http://img3.douban.com/icon/u60077520-5.jpg"};

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
            Image = _picurlList[RandomHelper.Next(_picurlList.Count)];
        }

    }
}
