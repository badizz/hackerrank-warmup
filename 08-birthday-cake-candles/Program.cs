using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_birthday_cake_candles
{
    class Program
    {
        // solution 1
        public static int birthdayCakeCandles(List<int> candles)
        {
            int maxVal = candles[0];
            int count = 1;
            for (int k = 1; k < candles.Count; k++)
            {
                if (candles[k] > maxVal)
                {
                    maxVal = candles[k];
                    count = 1;
                }
                else if (candles[k] == maxVal)
                {
                    count++;
                }
            }
            return count;
        }

        // solution 2
        public static int birthdayCakeCandles2(List<int> candles)
        {
            int maxVal = candles.Max();
            return candles.Where(x => x == maxVal).Count();
        }

        // solution 3
        public static int birthdayCakeCandles3(List<int> candles)
        {
            int maxVal = candles[0];
            foreach (int k in candles){
                maxVal = Math.Max(maxVal, k);
            }
            return candles.Count(x => x == maxVal);
        }

    }
}
