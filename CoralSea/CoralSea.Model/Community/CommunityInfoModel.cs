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

        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastActivityTime { get; set; }

        public DateTime CloseTime { get; set; }
    }
}
