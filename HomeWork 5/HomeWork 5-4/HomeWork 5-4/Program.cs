using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork_5_4
{

    class Program
    {

        static void Main(string[] args)
        {

            string path = "test.txt";

            string[] Clog = Directory.GetDirectories(@"C:\Users\Mons-Pc\source\repos\HomeWork\HomeWork 5\HomeWork 5-4\HomeWork 5-4", "*", SearchOption.AllDirectories);
            Console.WriteLine("Всего добавленно директорий {0}.", Clog.Length);
            string[] Flog = Directory.GetFiles(@"C:\Users\Mons-Pc\source\repos\HomeWork\HomeWork 5\HomeWork 5-4\HomeWork 5-4", "*", SearchOption.AllDirectories);
            Console.WriteLine("Всего добавленно файлов {0}.", Flog.Length);
            
            File.WriteAllLines(path,Clog);
            File.AppendAllText(path, Environment.NewLine);
            File.AppendAllLines(path,Flog);

            string path2 = "test.txt";

        }
        static string filere(string n)
        {
            if (n < 2)
                return n;
            return filere ;
        }
    }
}
