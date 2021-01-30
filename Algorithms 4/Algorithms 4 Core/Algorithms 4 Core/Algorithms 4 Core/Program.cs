using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algorithms_4_Core
{
    class Program
    {        
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
    public class BenhmarkClass
    {
        public static string RandomString()
        {
            StringBuilder newString = new StringBuilder();
            string chars = "qwertyuiopasdfghjklzxcvbnm";
            int Max = chars.Length;
            var rnd = new Random();
            for (int i = 0; i < Max; i++)
            {
                newString.Append(chars[rnd.Next(Max)]);
            }
            return newString.ToString();
        }        

        [Benchmark]
        public void TestHash()
        {
            HashSet<string> hash = new HashSet<string>();
            int x = 10000;
            for (int i = 0; i < x; i++)
            {
                hash.Add(RandomString());
            }
            hash.Contains(RandomString());
        }
        [Benchmark]
        public void TestArray()
        {            
            int x = 10000;
            string[] array = new string[x];
            for (int i = 0; i < x; i++)
            {                
                array[i] = RandomString();
            }
            for (int i = 0; i < x; i++)
            {
                if (array[i] == RandomString())
                { break; }
            }
        }
    }
}
