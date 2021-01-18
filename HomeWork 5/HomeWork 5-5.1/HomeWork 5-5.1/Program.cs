using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace HomeWork_5_5._1
{      
    class Program
    {
        static void Main(string[] args)
        {
            List<ToDo> tasks = new List<ToDo>();
            string filename = "TaskList.json"; /// имя файла json 
            if (File.Exists(filename))
            {
              tasks = JsonSerializer.Deserialize<List<ToDo>>(File.ReadAllText(filename));
            }           
            while (true)
            {                
                Console.Clear();
                int count = 1;
                foreach (ToDo task in tasks)
                {
                    task.Print(count++);                    
                }                
                Console.WriteLine("Чтобы добавить задачу введите 0,введите номер задачи чтобы изменить/удалить ее");
                string s = Console.ReadLine();
                if (s == "0")
                {
                    tasks.Add(ToDo.CreateNewTask());
                }
                else
                {
                    if (int.TryParse(s, out int num))
                    {
                        Console.WriteLine("Если хотите изменить задачу нажмите 1,\n" +
                            "Изменить статус нажмите 2,\n" +
                            "Удалить задачу 3");                       
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                {tasks[num - 1].ChangeTitle();break;}
                            case ConsoleKey.D2:
                                {tasks[num - 1].ChangeStatus();break;}
                            case ConsoleKey.D3:
                                {tasks.RemoveAt(num - 1);break;}                            
                        }                      
                    }
                    else 
                    { 
                        Console.WriteLine("Что-то пошло не так, подумай еще раз!");
                        Console.ReadLine();
                    }
                }                
                File.WriteAllText(filename, JsonSerializer.Serialize<List<ToDo>>(tasks));
            }
        }
    }  
}