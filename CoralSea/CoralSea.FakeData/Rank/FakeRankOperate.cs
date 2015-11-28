using CoralSea.Common;
using CoralSea.Model.Rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.FakeData.Rank
{
    public class FakeRankOperate : RankOperateModel
    {
        public FakeRankOperate(int userId)
        {
            UserId = userId;
            RankId = RandomHelper.Next(100);
            OperateTime = DateTime.Now;
        }
        public FakeRankOperate(int userId, DateTime time)
        {
            UserId = userId;
            RankId = RandomHelper.Next(100);
            OperateTime = time;
        }

        public static IEnumerable<FakeRankOperate> CreateRankOperateList(int userId)
        {
            var count = RandomHelper.Next(100);
            while (count-- > 0)
            {
                yield return new FakeRankOperate(userId);
            }
        }
        public static IEnumerable<FakeRankOperate> CreateRankOperateList(int userId, DateTime time)
        {
            var count = RandomHelper.Next(100);
            while (count-- > 0)
            {
                yield return new FakeRankOperate(userId, time);
            }
        }
        public static IEnumerable<FakeRankOperate> CreateRankOperateList(int userId, DateTime start, DateTime end)
        {
            var count = RandomHelper.Next(100);
            while (count-- > 0)
            {
                yield return RandomHelper.Bool() ? new FakeRankOperate(userId, start) : new FakeRankOperate(userId, end);
            }
        }
    }
}
