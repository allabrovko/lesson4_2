using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_2
{
    class Program
    {

        private static void task2(int n)
        {
         
            Console.WriteLine($"All dividers of {n}");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            task2(26);

        }
    }
}
