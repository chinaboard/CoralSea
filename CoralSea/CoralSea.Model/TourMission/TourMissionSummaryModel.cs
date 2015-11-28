using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.Model.TourMission
{
    /// <summary>
    /// 新手任务摘要
    /// </summary>
    public class TourMissionSummaryModel
    {
        public string MissionTitle { get; set; }

        public int MissionRank { get; set; }

        public TourMissionStatus Status { get; set; }
    }

    public enum TourMissionStatus : int
    {
        /// <summary>
        /// 尚未领取
        /// </summary>
        [Description("尚未领取")]
        NotPull = 0,

        /// <summary>
        /// 正在进行中
        /// </summary>
        [Description("正在进行中")]
        Underway = 0x01,

        /// <summary>
        /// 完成
        /// </summary>
        [Description("完成")]
        Completed = 0x01 << 1,

        /// <summary>
        /// 失败
        /// </summary>
        [Description("失败")]
        Fail = 0x01 << 2,

        /// <summary>
        /// 放弃
        /// </summary>
        [Description("放弃")]
        Abort = 0x01 << 3
    }
}
