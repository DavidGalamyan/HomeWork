using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] array = new string [5, 2];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2;j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Введите имя контакта");
                    }
                    if (j == 1)
                    {
                        Console.WriteLine("Введите номер телефона или e-mail контакта");
                    }
                    array[i, j] = Console.ReadLine();                                        
                }
                
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
