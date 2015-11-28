using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.Model.Community
{
    /// <summary>
    /// 圈子操作结果
    /// </summary>
    public class CommunityOperationResult
    {
        public bool IsSucceed { get; set; }

        public string ErrorMessage { get; set; }
    }
}
