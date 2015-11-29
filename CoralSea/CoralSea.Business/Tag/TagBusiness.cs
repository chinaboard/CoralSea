using CoralSea.IBusiness.Tag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoralSea.Model.Tag;
using CoralSea.Common;
using CoralSea.FakeData.Tag;

namespace CoralSea.Business.Tag
{
    public class TagBusiness : ITagBusiness
    {
        public void AddTag(TagModel model)
        {
            /*throw new NotImplementedException();*/
        }

        public List<TagModel> GetHostTags(int topK)
        {
            var list = new List<TagModel>();
            var count = RandomHelper.Next(topK);
            while (count-- > 0)
            {
                list.Add(new FakeTag());
            }
            return list;
        }

        public List<TagModel> GetRecommendTags(int userId)
        {
            return GetTags();
        }

        public List<TagModel> GetTags()
        {
            var list = new List<TagModel>();
            var count = RandomHelper.Next(100);
            while (count-- > 0)
            {
                list.Add(new FakeTag());
            }
            return list;
        }
    }
}
