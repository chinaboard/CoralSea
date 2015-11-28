using CoralSea.IBusiness.Rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.Rank;
using CoralSea.FakeData.Rank;

namespace CoralSea.Business.Rank
{
    public class RankInfoBusiness : IRankInfoBusiness
    {
        public RankInfoModel GetRankInfo(int id)
        {
            return new FakeRankInfo(id);
        }
    }
}
