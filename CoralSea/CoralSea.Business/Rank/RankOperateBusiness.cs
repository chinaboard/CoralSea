using CoralSea.IBusiness.Rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.Rank;
using CoralSea.FakeData.Rank;
using CoralSea.Common;

namespace CoralSea.Business.Rank
{
    public class RankOperateBusiness : IRankOperateBusiness
    {
        public bool AddRankOperate(RankOperateModel model)
        {
            return RandomHelper.Bool();
        }

        public IEnumerable<RankOperateModel> GetUserAllRankOperate(int userId)
        {
            return FakeRankOperate.CreateRankOperateList(userId);
        }

        public IEnumerable<RankOperateModel> GetUserDayRankOperate(int userId, DateTime time)
        {
            return FakeRankOperate.CreateRankOperateList(userId, time);
        }

        public IEnumerable<RankOperateModel> GetUserTimesRankOperate(int userId, DateTime start, DateTime end)
        {
            return FakeRankOperate.CreateRankOperateList(userId, start, end);
        }

        public bool UpdateRankOperate(int userId, RankOperateModel model)
        {
            return RandomHelper.Bool();
        }
    }
}
