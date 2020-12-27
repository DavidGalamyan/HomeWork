using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4_2
{
    class Program
    {

        static void Main(string[] args)
        {


            string s = Console.ReadLine();

            string[] ss = s.Split(' ');
            int sum = 0;
            int[] numbers = new int[ss.Length];

            for (int i = 0; i <= ss.Length - 1; i++) 
            {
                int number = Convert.ToInt32(ss[i]); 
                numbers[i] = number;
                sum += numbers[i];                
            }
            Console.WriteLine(sum);
        }   
    }
}   





