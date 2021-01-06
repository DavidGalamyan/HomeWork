using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork_5_2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            File.AppendAllText(filename, Environment.NewLine);
            DateTime hour = DateTime.Now;
            File.AppendAllText(filename, hour.ToString("%h:m:s"));

            
            


        }
    }

    
}
