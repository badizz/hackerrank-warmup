using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_solve_me_first
{
    class Program
    {
        static int solveMeFirst(int a, int b)
        {
            return a + b;
        }
        static void Main(String[] args)
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }
    }
}
