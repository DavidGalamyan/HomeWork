using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_4_Core
{
    class Program
    {       
        public static string RandomString()
        {            
            StringBuilder newString = new StringBuilder();
            string chars = "qwertyuiopasdfghjklzxcvbnm";
            int LENGTH = chars.Length;
            var rnd = new Random();
            for (int i = 0; i < LENGTH; i++)
            {
                newString.Append(chars[rnd.Next(LENGTH)]);
            }
            return newString.ToString();
        }

        static void Main(string[] args)
        {
            HashSet<string> hash = new HashSet<string>();
            int x = 10000;
            string[] array = new string[x];
            for (int i = 0; i < x; i++)
            {
                hash.Add(RandomString());
                array[i] = RandomString();
            }           
        }
    }
}
