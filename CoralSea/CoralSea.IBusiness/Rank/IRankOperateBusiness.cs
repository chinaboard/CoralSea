using CoralSea.Model.Rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.IBusiness.Rank
{
    public interface IRankOperateBusiness
    {
        /// <summary>
        /// 获取所有积分操作
        /// </summary>
        /// <returns></returns>
        IEnumerable<RankOperateModel> GetUserAllRankOperate();
        /// <summary>
        /// 获取某天积分操作
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        IEnumerable<RankOperateModel> GetUserDayRankOperate(DateTime time);
        /// <summary>
        /// 获取某时间段积分操作
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        IEnumerable<RankOperateModel> GetUserTimesRankOperate(DateTime start, DateTime end);

        bool AddRankOperate(RankOperateModel model);

        bool UpdateRankOperate(int id, RankOperateModel model);
    }
}
