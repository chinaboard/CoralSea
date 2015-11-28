using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.Novice;

namespace CoralSea.IBusiness.Novice
{
    /// <summary>
    /// 个人基本信息业务逻辑
    /// </summary>
    public interface IPersonalInfoBusiness
    {
        bool AddPersonalInfo(PersonalInfoModel model);

        bool UpdatePersonalInfo(int id, PersonalInfoModel model);

        PersonalInfoModel GetPersonalInfo(int id);
    }
}
