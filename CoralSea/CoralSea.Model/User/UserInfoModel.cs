using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.Model.User
{
    public class UserInfoModel
    {
        public int Id { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string JobNumber { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 花名
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 头像URL
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 入职时间
        /// </summary>
        public DateTime EntryTime { get; set; }

        /// <summary>
        /// 组织架构
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// 兴趣
        /// </summary>
        public List<string> Interesting { get; private set; } = new List<string>();

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string Signature { get; set; }
    }
}
