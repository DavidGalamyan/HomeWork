using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.name))
            {

                Console.WriteLine("Введите имя пользователя");
                Properties.Settings.Default.name = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.age))
            {

                Console.WriteLine("Введите возраст пользователя");
                Properties.Settings.Default.age = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.career))
            {

                Console.WriteLine("Введите род дейтельности пользователя:");
                Properties.Settings.Default.career = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string name = Properties.Settings.Default.name;
            string age = Properties.Settings.Default.age;
            string career = Properties.Settings.Default.career;
            Console.WriteLine($"{name}, {age}, {career}");
        }

    }
}

