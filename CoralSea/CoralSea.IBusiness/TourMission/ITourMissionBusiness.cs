using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.TourMission;

namespace CoralSea.IBusiness.TourMission
{
    public interface ITourMissionBusiness
    {
        TourMissionModel GetTourMission(int missionId);

        TourMissionCompleteResult CompleteMission<T>(int missionId, T completeModel);

        bool IsFinishedAllMustMission(int userId);
    }
}
