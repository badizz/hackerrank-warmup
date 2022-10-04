using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_very_big_sum
{
    class Program
    {
        // solution 1
        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            return sum;
        }

        // solution 2
        public static long aVeryBigSum2(List<long> ar)
        {
            return ar.Sum();
        }

    }
}
