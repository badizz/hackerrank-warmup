using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_compare_triplets
{
    class Program
    {

        // solution 1
        public static List<int> compareTriplets1(List<int> a, List<int> b)
        {
            int winnerAlice = 0;
            int winnerBob = 0;
            for (int counter = 0; counter < a.Count; counter++)
            {
                if (a[counter] > b[counter])
                    winnerAlice++;
                else if (b[counter] > a[counter])
                    winnerBob++;
            }
            return new List<int> { winnerAlice, winnerBob };
        }


        // another way
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> scores = new List<int>() { 0, 0 };
            for (int k = 0; k < a.Count; k++)
            {
                if (a[k] > b[k]) scores[0]++;
                else if (b[k] > a[k]) scores[1]++;
            }
            return scores;
        }


    }
}
