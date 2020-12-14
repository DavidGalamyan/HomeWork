using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double min;
            double max;
            double absolute0 = -273;
            while (true)
            {
                Console.WriteLine("Введите минимальную температуру за сутки");
                min = Convert.ToDouble(Console.ReadLine());
                if (min < absolute0)
                    Console.WriteLine("Вы ввели невозможное значение, попробуйте еще раз");
                else
                {
                    Console.WriteLine("Введите максимальную температуру за сутки");
                    max = Convert.ToDouble(Console.ReadLine());
                    if (max < min)
                        Console.WriteLine("Вы ввели невозможное значение, попробуйте еще раз");
                    else
                    {
                        Console.WriteLine("Средняя температура за сутки " + (min + max) / 2);
                        return;
                    }
                }
            }
        }
    }
}
