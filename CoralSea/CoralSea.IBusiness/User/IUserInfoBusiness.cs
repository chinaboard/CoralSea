using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.User;

namespace CoralSea.IBusiness.User
{
    public interface IUserInfoBusiness
    {
        UserInfoModel GetUserInfo(int id);

        bool UpdateUserInfo(UserInfoModel model);
    }
}
