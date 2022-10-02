using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_simple_array_sum
{
    class Program
    {
        // solution 1
        public static int simpleArraySumSolution1(List<int> ar)
        {
            return ar.AsQueryable().Sum();
        }

        // solution 2
        public static int simpleArraySumSolution2(List<int> ar)
        {
            int result = 0;
            result = ar.Sum(x => Convert.ToInt32(x));
            return result;
        }

        // solution 3
        public static int simpleArraySumSolution3(List<int> ar)
        {
                int result = 0;
                foreach (int k in ar){
                    result += k;
                }
                return result;
        }

    }
}
