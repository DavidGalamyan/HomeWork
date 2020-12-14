using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2_2
{
    class Program
    {
        public enum moth
        {
            Январь = 1,
            Февраль = 2,
            Март = 3,
            Апрель = 4,
            Май = 5,
            Инюнь = 6,
            Июль = 7,
            Август = 8,
            Сентябрь = 9,
            Октябрь = 10,
            Ноябрь = 11,
            Декабрь = 12
        }

        static void Main(string[] args)
        {

             while (true)
             {
                  Console.WriteLine("Введите номер текущего месяца (1-12)");
                int nummoth = Convert.ToInt32(Console.ReadLine());
                if (nummoth > 12 || nummoth < 1)
                {
                    Console.WriteLine("Яж тебе говорю от 1 до 12, попробуй еще раз...");
                }
                else
                {
                    Console.WriteLine((moth)nummoth);
                    return;
                }
             }
           //// Надеюсь, не изабрел колесо, хотел чего-то необычного)
        }
    }
}
