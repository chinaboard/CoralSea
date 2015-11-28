using CoralSea.Common;
using CoralSea.Model.Rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.FakeData.Rank
{
    public class FakeRankInfo : RankInfoModel
    {
        public FakeRankInfo(int id)
        {

            Id = id;
            Type = RandomHelper.Next();
            Name = "Jifen" + Type;
            OnlyFirst = RandomHelper.Bool();
            DayLimit = RandomHelper.Next(1000);
            Step = RandomHelper.Next(-100, 100);
            Description = "yooooo" + Name;
        }

    }
}
