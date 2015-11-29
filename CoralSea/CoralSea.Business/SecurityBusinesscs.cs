using CoralSea.IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model;
using CoralSea.Common;

namespace CoralSea.Business
{
    public class SecurityBusinesscs : ISecurityBusinesscs
    {
        public UserVerifyResult UserVerify(UserLoginModel model)
        {
            return new UserVerifyResult
            {
                Result = true,
                UserId = RandomHelper.Next(2345)
            };
        }
    }
}
