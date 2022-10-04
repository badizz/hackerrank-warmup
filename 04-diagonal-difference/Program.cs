using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_diagonal_difference
{
    class Program
    {
        // solution 1
        public static int diagonalDifference(List<List<int>> arr)
        {
            int sumLtoR = 0, sumRtoL = 0;
            int arrSize = arr.Count();
            for (int i = 0; i < arrSize; i++)
            {
                for (int j = 0; j < arrSize; j++)
                {
                    if (i == j) sumRtoL += arr[i][j];
                    if (j == arrSize - i - 1) sumLtoR += arr[i][j];
                }
            }
            return Math.Abs(sumRtoL - sumLtoR);
        }


        // solution 2 | contains only 1 for loop
        public static int diagonalDifference2(List<List<int>> arr)
        {
            int arrSize = arr.Count();
            int sumRL = 0, sumLR = 0;
            for (int i = 0; i < arrSize; i++){
                sumLR += arr[i][i];
                sumRL += arr[i][arrSize - i - 1];
            }
            return Math.Abs(sumLR - sumRL);
        }
    }
}
