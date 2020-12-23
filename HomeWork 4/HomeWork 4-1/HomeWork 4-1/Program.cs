using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4_1
{
    class Program
    {
        /* Способ 1
        static void Main(string[] args)
        {
            string userFirstName;
            string userLastName;
            string userPatronymic;
            (userFirstName, userLastName, userPatronymic) = AskUserName();
            Console.WriteLine($"Ваше ФИО {userFirstName} { userLastName } { userPatronymic }");
        }
        

        static (string FN, string LN, string P) AskUserName()
        {
            Console.WriteLine("Ваша фамилия?");
            string name1 = Console.ReadLine();
            Console.WriteLine("Ваше имя?");
            string name2 = Console.ReadLine();
            Console.WriteLine("Ваше отчество?");
            string name3 = Console.ReadLine();
            Console.Clear();
            return (name1, name2, name3);
        }
        */
        //Способ 2

        static void Main(string[] args)
        {
            Console.WriteLine("Сколько человек вы хотите поприветствовать?");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] array = new string [n];
            for (int i = 0; i < n; i++)
            {
                string Firstname = GetUserFirstName();
                string LastName = GetUserLastName();
                string Patronymic = GetUserPatronymic();
                string FullName = getFullName(Firstname, LastName, Patronymic);
                array[i] = FullName;
                Console.Clear();
            }
            for (int i = 0; i < n;i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static string GetUserFirstName()
        {
            Console.WriteLine("Фамилия?");
            string userFirstName = Console.ReadLine();
            return userFirstName;
        }

        static string GetUserLastName()
        {
            Console.WriteLine("Имя?");
            string UserLastName = Console.ReadLine();
            return UserLastName;
        }
        static string GetUserPatronymic()
        {
            Console.WriteLine("Отчество?");
            string UserPatronymic = Console.ReadLine();
            return UserPatronymic;
        }

        static string getFullName(string userFirstName, string UserLastName, string UserPatronymic)
        {
            return $"Здравствуйте, {userFirstName} { UserLastName} { UserPatronymic}!";
        }

        



    }
}
