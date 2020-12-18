using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for (int x = s.Length - 1; x >= 0; x--)
            {
                char sum = s[x];
                Console.Write(sum + "");
            }
            string greeting = "Hello, world!";
            for (int i = greeting.Length - 1; i >=0 ; i--)
            {
                Console.Write(greeting[i]); 
            }
            ///Два варианта решения, просто так
        }
    }
}
