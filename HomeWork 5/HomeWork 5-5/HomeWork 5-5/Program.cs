using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;



namespace HomeWork_5_5
{

    public class ToDo
    {
        public string Title { get; set; }


        public bool IsDone { get; set; }

        public ToDo(bool isdone, string title)
        {
            IsDone = isdone;
            Title = title;
        }

    }

    class Program
    {
        
        static void Main(string[] args)
        {
            //string filename = "tasks.json";
            //string[] arTasks = File.ReadAllLines(filename);
            //for (int i = 0; i < arTasks.Length; i++)
            //{
            //    Console.WriteLine(arTasks[i]);
            //}
            
            ToDo task1 = new ToDo(true, "Сделать 5 задачу");
            
            Console.WriteLine(task1.Title);

        }
    }
}
