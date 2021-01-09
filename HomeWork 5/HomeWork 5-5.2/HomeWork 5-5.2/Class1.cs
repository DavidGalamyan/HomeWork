using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace HomeWork_5_5._2
{
    public class Class1
    {
        static void Main()
        {
            
            string fileName = "task.json";
            string jsonString = File.ReadAllText(fileName);
            ///string weatherForecast = JsonSerializer.Deserialize<ToDo>(jsonString);

            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());

            ToDo task = new ToDo("Sasda", "sas");

        }
    }
}
