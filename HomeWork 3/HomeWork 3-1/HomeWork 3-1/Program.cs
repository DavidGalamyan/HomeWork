using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int s = 0; s < 3; s++)
                {
                    if (i == s)
                    {
                        array[i, s] = a;
                    }
                    Console.Write(array[i, s] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
