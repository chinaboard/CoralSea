using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.Model.Community
{
    public class CommunityMemberModel
    {
        public CommunityMemberType MemberType { get; set; } = CommunityMemberType.Human;

        /// <summary>
        /// 圈子成员的关联ID，若成员类型为真实人，则为用户ID，若类型为圈子，则ID为圈子ID
        /// </summary>
        public int RelatedId { get; set; }

        public string MemberName { get; set; }

        public string Image { get; set; }

        public DateTime JoinTime { get; set; }
    }

    public enum CommunityMemberType : int
    {
        /// <summary>
        /// 真实人
        /// </summary>
        Human = 0x01,

        /// <summary>
        /// 圈子
        /// </summary>
        Virtual = 0x01 << 1
    }
}
