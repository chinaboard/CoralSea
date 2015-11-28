using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoralSea.Model;

namespace CoralSea.IBusiness
{
    public interface ISecurityBusinesscs
    {
        UserVerifyResult UserVerify(UserLoginModel model);
    }
}
