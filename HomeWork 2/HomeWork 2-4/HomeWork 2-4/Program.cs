using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца");
            int nummonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру, за день");
            double maxtp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минимальную температуру, за день");
            double mintp = Convert.ToInt32(Console.ReadLine());
            double midtp = (mintp + maxtp) / 2;
            if (nummonth == 12 || nummonth == 1 || nummonth == 2 && midtp > 0)
            {
                Console.WriteLine("Дождливая зима");
                Console.WriteLine(midtp);
            }
            /// (Конечно, если бы мы жили на юге, то месяцы были другие) ) 
        }
    }
}
