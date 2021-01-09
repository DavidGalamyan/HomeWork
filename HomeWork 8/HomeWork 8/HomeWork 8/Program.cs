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
            if (string.IsNullOrEmpty(Properties.Settings.Default.Name))
            {
                Console.WriteLine("Введите ваше имя");
                Properties.Settings.Default.Name = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.Age))
            {
                Console.WriteLine("Ваш возраст?");
                Properties.Settings.Default.Age = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.occupation))
            {
                Console.WriteLine("Чем Вы занимаетесь?");
                Properties.Settings.Default.occupation = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string userName = Properties.Settings.Default.Name;
            string userAge = Properties.Settings.Default.Age;
            string userOccu = Properties.Settings.Default.occupation;
            Console.WriteLine($"{userName}, {userAge}, {userOccu}!");
        }
    }
}
