using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа от 0 до 255, через пробел");
            string filename = "array.bin";
            string str = Console.ReadLine();
            string[] strsplit = str.Split(' ');
            byte[] num = new byte[strsplit.Length];
            for (int i = 0; i < strsplit.Length; i++)
            {               
                byte temp = Convert.ToByte(strsplit[i]);
                num[i] = temp;             
            }
            File.WriteAllBytes(filename, num);
                    
        }
    }
}
