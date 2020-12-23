using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Fibonahhi(n));
        }


        static int Fibonahhi(int n)
        {            
            if (n < 2)
                return n;                 
                return Fibonahhi(n-1) + Fibonahhi(n-2);
        }
    }
}


/*namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFactorial(5));
        }


        static int GetFactorial(int number)
        {
            if (number == 1)
            {
                return number;
            }
            return number * GetFactorial(number - 1);
        }
    }
}*/

