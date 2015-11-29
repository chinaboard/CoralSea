using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.Common
{
    public static class RandomHelper
    {
        static Random _random = new Random();

        public static bool Bool()
        {
            return _random.Next(100) > 50;
        }

        public static int Next()
        {
            return _random.Next();
        }
        public static int Next(int maxValue)
        {
            return _random.Next(maxValue);
        }
        public static int Next(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }

        public static DateTime Time()
        {
            var time = TimeSpan.FromMinutes(Next(500000));
            return DateTime.Now.Subtract(time);
        }
    }
}
