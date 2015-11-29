using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.Tag;

namespace CoralSea.IBusiness.Tag
{
    public interface ITagBusiness
    {
        void AddTag(TagModel model);

        List<TagModel> GetTags();

        List<TagModel> GetHostTags(int topK);

        List<TagModel> GetRecommendTags(int userId);
    }
}
