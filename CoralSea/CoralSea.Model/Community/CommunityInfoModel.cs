using CoralSea.Model.Tag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.Model.Community
{
    public class CommunityInfoModel
    {
        public int CommunityId { get; set; }

        public int ParentId { get; set; }

        public string ParentName { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        /// <summary>
        /// 圈子管理员ID
        /// </summary>
        public int MasterId { get; set; }

        public string Description { get; set; }

        public List<TagModel> Tags { get; private set; } = new List<TagModel>();

        public int MemberCount { get; set; }

        public bool HasCurrentUserJoin { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastActivityTime { get; set; }

        public DateTime CloseTime { get; set; }
    }
}
