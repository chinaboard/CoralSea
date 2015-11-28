using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.Model.Community
{
    public class TopicReplyModel
    {
        public int ReplyId { get; set; }

        public int ReplyMemberId { get; set; }

        public string ReplyMemberName { get; set; }

        public DateTime ReplyTime { get; set; }

        public int TopicId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public List<string> AdditionalFileList { get; private set; } = new List<string>();
    }
}
