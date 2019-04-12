using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.Common
{
    public static class Tools
    {
        public static string RandomBinary(int length)
        {
            var random = new Random();
            var builder = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                var randomBit = random.Next(0, 2);
                builder.Append(randomBit);
            }
            return builder.ToString();
        }

        public static double rastrigin(double x, double y)
        {
            return 20 + Math.Pow(x, 2) + Math.Pow(y, 2) - (10 * (Math.Cos(2 * Math.PI * x) + Math.Cos(2 * Math.PI * y)));
        }
    }
}
