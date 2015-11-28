using CoralSea.IBusiness.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.User;
using CoralSea.FakeData.User;

namespace CoralSea.Business.User
{
    public class UserInfoBusiness : IUserInfoBusiness
    {
        public UserInfoModel GetUserInfo(int id)
        {
            return new FakeUserInfo(id);
        }

        public bool UpdateUserInfo(UserInfoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
