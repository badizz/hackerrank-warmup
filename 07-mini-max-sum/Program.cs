using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_mini_max_sum
{
    class Program
    {
        // solution 1
        public static void miniMaxSum(List<int> arr)
        {
            long minVal = long.MaxValue;
            long maxVal = long.MinValue;
            long arrSumVal = 0;

            for (int k = 0; k < 5; k++)
            {
                if (arr[k] < minVal)
                    minVal = arr[k];
                if (arr[k] > maxVal)
                    maxVal = arr[k];
                arrSumVal += arr[k];
            }
            Console.WriteLine((arrSumVal - maxVal) + " " + (arrSumVal - minVal));
        }

        // solution 2
        public static void miniMaxSum2(List<int> arr)
        {
            long minVal = long.MaxValue;
            long maxVal = long.MinValue;
            long arrSumVal = 0;

            foreach (int k in arr)
            {
                minVal = Math.Min(minVal, k);
                maxVal = Math.Max(maxVal, k);
                arrSumVal += k;
            }
            Console.WriteLine($"{arrSumVal - maxVal} {arrSumVal - minVal}");
        }

        // another way
        public static void miniMaxSum3(List<int> arr)
        {
            arr.Sort();
            long minVal = arr.Take(4).Sum(x => (long)x);
            long maxVal = arr.Skip(1).Sum(x => (long)x);
            Console.WriteLine($"{minVal} {maxVal}");
        }

    }
}
