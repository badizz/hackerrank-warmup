using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_plus_minus
{
    class Program
    {
        public static void plusMinus(List<int> arr)
        {
            double posNum = 0, negNum = 0, zerNum = 0;
            int arrSize = arr.Count;
            if (arrSize > 0 && arrSize <= 100)
            {
                foreach (int num in arr)
                {
                    if (num >= -100 && num <= 100)
                    {
                        if (num > 0)
                            posNum++;
                        else if (num < 0)
                            negNum++;
                        else
                        {
                            zerNum++;
                        }
                    }
                }
                Console.WriteLine(string.Format("{0:0.000000}", (posNum / arrSize)));
                Console.WriteLine(string.Format("{0:0.000000}", (negNum / arrSize)));
                Console.WriteLine(string.Format("{0:0.000000}", (zerNum / arrSize)));
            }
        }

    }
}
