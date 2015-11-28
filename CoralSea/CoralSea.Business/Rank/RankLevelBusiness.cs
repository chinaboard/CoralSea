using CoralSea.IBusiness.Rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.Rank;

namespace CoralSea.Business.Rank
{
    public class RankLevelBusiness : IRankLevelBusiness
    {
        public RankLevelModel GetRankLevel(int integral)
        {
            var model = new RankLevelModel() { Integral = integral };
            model.Crown = model.Integral / 4 / 4 / 4;
            model.Sun = model.Integral / 4 / 4 - model.Crown * 4;
            model.Sun = model.Sun < 0 ? 0 : model.Sun;
            model.Moon = model.Integral / 4 - model.Sun * 4 - model.Crown * 16;
            model.Moon = model.Moon < 0 ? 0 : model.Moon;
            model.Star = model.Integral - model.Moon * 4 - model.Sun * 16 - model.Crown * 64;
            model.Star = model.Star < 0 ? 0 : model.Star;
            return model;
        }
    }
}
