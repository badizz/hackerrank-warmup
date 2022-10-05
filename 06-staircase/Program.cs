using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_staircase
{
    class Program
    {
        // solution 1
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if ((i + j) > n){
                        Console.Write("#");
                    }
                    else{
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        // solution 2
        public static void staircase2(int n)
        {
            for (int j = 0; j < n; j++)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + j < n ? " " : "#");
                }
                Console.WriteLine("");
            }
        }

        // another way | contains only 1 for Loop
        public static void staircase3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string spaces = new String(' ', (n - i));
                string sharps = new String('#', i);
                Console.WriteLine($"{spaces}{sharps}");
            }
        }

    }
}
