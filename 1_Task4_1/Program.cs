using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int S = 0;
            int n = 2 * N - 1;

            for (int i = 1; i <= n; i += 2)
            {
                S += i;
                Console.WriteLine(S);
            }
            Console.ReadKey();
        }
    }
}
