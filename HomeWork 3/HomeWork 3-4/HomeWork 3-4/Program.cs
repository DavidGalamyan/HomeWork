using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3_4
{
    class Program
    {
        static void Main(string[] args)
        {  
            string[,] array = new string[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    array[i, j] = "O";
                   

                }               
            }

            int count = 0;
            bool cycle = true;
            Console.WriteLine("Здравствуй, расставь свои корабли для Морского Боя");
            Console.WriteLine("Напомню правила, корабли не должны касатся друг друга");
            Console.WriteLine("Так же части кораблей от 4-х палубного до 2-х палубного, нужно размещать вместе это же части единого целого!");
            Console.WriteLine("Если начал ставить 4-х палубник на 1.1 то продолжить его установку на 3.3 уже не возможно, это наршение правил!");
            Console.WriteLine("Горизонталь или вертекаль решай сам, но их нельзя устоновить по диагонали, и под углом 90 градусов");
            Console.WriteLine("Не периживай! Буду тебе подсказывать когда и что ты ставишь");
            while (cycle)
            {
                
                if (count == 0)
                {
                  Console.WriteLine("Готов? Поехали!");
                  Console.WriteLine("Сейчас 4-х палубный");

                }
                if (count == 4)
                {
                  Console.WriteLine("Отлично теперь два 3-х палубных");
                }
                if (count == 10)
                {
                  Console.WriteLine("Так комрад, теперь три 2-х палубных");
                }
                if (count == 16)
                {
                    Console.WriteLine("А у тебя неплохо выходит, давай четыре мелких по 1-й палубе и в бой");
                }
                if (count == 20)
                {
                    Console.WriteLine("Не ну ты конечно красавец, но игра в алфе, жди релиза и сможешь вступить в бой!)");
                    cycle = false;
                }

                Console.WriteLine("Введите кординату строки на котором будет распологаться корабль/часть");
                int per = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите кординату столбца на котором будет распологаться корабль/часть");
                int per2 = Convert.ToInt32(Console.ReadLine());
                

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (per - 1 == i && per2 - 1 == j)
                        {
                            count++;
                            array[i, j] = "X";
                        }
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
