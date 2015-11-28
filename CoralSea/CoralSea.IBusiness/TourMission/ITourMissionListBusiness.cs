using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.TourMission;

namespace CoralSea.IBusiness.TourMission
{
    /// <summary>
    /// 新手任务列表业务逻辑接口
    /// </summary>
    public interface ITourMissionListBusiness
    {
        List<TourMissionSummaryModel> GetTourMissioinList(TourMissionStatus status, bool isGetAll = false);
    }
}
