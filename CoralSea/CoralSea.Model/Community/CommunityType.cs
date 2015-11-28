using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.Model.Community
{
    /// <summary>
    /// 圈子的类型
    /// </summary>
    public enum CommunityType : int
    {
        /// <summary>
        /// 组织架构
        /// </summary>
        [Description("组织架构")]
        RealGroup = 0x01,

        /// <summary>
        /// 专项
        /// </summary>
        [Description("专项")]
        VirtualGroup = 0x01 << 1,

        /// <summary>
        /// 兴趣
        /// </summary>
        [Description("兴趣")]
        InterestingGroup = 0x01 << 2
    }
}
