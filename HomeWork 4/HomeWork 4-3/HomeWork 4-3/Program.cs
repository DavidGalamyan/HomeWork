using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4_3
{
    class Program
    {
        enum season
        {
             Winter = 1,
             Spring,
             Summer,
             Autumn
        }       
        static string SeasMonth (int num)
        {
            

            switch (num)
            {
                case 1:
                    return "Зима";                 
                case 2:
                    return "Весна";                   
                case 3:
                    return "Лето";                   
                case 4:
                    return "Осень";                    
                case 0:
                    return "Ошибка: введите число от 1 до 12";
            }
            return "Ошибка: введите число от 1 до 12";
        }
        static int Num(int num)
        {
            if (num == 12 || num == 1 || num == 2)
            { return num = 1; }
            if (num == 3 || num == 4 || num == 5)
            { return num = 2; }
            if (num == 6 || num == 7 || num == 8)
            { return num = 3; }
            if (num == 9 || num == 10 || num == 11)
            { return num = 4; }
            else
                return 0;        
        }
        static void Main(string[] args)
        {
            int nummonth = Convert.ToInt32(Console.ReadLine());
            nummonth = Num(nummonth);
            Console.WriteLine(SeasMonth(nummonth));
            season s;
            switch (s)
            {
                case season.Winter:
                     break; 
                case season.Spring:
                    break;
                case season.Summer:
                    break;
                case season.Autumn:
                    break;
                default:
                    break;
            }

        }


    }
}
