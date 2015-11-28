using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.Model.Rank
{
    public class RankInfoModel
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public bool OnlyFirst { get; set; }
        public int DayLimit { get; set; }
        public int Step { get; set; }
        public string Description { get; set; }
    }
}
