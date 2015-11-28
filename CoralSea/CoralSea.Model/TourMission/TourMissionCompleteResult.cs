using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.Model.TourMission
{
    public class TourMissionCompleteResult
    {
        public bool IsFinished { get; set; }

        public string FailureInfo { get; set; }

        public int NextMission { get; set; } = -1;
    }
}
