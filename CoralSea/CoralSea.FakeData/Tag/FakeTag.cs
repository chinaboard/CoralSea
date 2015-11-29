using CoralSea.Common;
using CoralSea.Model.Tag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.FakeData.Tag
{
    public class FakeTag : TagModel
    {
        public FakeTag()
        {
            TagId = RandomHelper.Next(35345);
            TagName = FakeName.MakeFakeTag();
            HotDegree = RandomHelper.Next(5000);
        }
    }
}
