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
            model.Level = GetLevel(integral);
            model.Crown = model.Level / 4 / 4 / 4;
            model.Sun = model.Level / 4 / 4 - model.Crown * 4;
            model.Sun = model.Sun < 0 ? 0 : model.Sun;
            model.Moon = model.Level / 4 - model.Sun * 4 - model.Crown * 16;
            model.Moon = model.Moon < 0 ? 0 : model.Moon;
            model.Star = model.Level - model.Moon * 4 - model.Sun * 16 - model.Crown * 64;
            model.Star = model.Star < 0 ? 0 : model.Star;

            return model;
        }

        public int GetLevel(int integral)
        {
            for (int i = 2; i < 200; i++)
                if (i * i + 4 * i >= integral)
                    return i - 1;
            return 1;
        }
    }
}
