using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "random.txt";
            File.WriteAllText(filename, Console.ReadLine());
        }
    }
}
