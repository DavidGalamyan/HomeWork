using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f0=0;
            int f1=1;
            int fN;
            
            
            for (int i = 0; i < n - 1; i++)
            {
                fN = f0 + f1;
                f0 = f1;
                f1 = fN;
                Console.WriteLine(fN);

            }
        }
        static int Fibo(int n)
        {
            if(n<2)
            return n;
            return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
