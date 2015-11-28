using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.Model.Community
{
    public class TopicModel
    {
        public int TopicId { get; set; }

        public int CreatorId { get; set; }

        public string TopicTitle { get; set; }

        public int ViewCount { get; set; }

        public int ReplyCount { get { return ReplyList.Count; } }

        public TopicReplyModel LastReply { get; set; }

        public TopicStatus Status { get; set; } = TopicStatus.Normal;

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public List<TopicReplyModel> ReplyList { get; private set; } = new List<TopicReplyModel>();
    }

    public enum TopicStatus : int
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 0,

        /// <summary>
        /// 已结束
        /// </summary>
        [Description("已结束")]
        Finished = 0x01,

        /// <summary>
        /// 已关闭
        /// </summary>
        [Description("已关闭")]
        Closed = 0x01 << 1
    }
}
