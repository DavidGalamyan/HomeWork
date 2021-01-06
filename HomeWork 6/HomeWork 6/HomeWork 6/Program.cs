using System;
using System.Diagnostics;
using System.ComponentModel;

namespace MyProcessSample
{
    class MyProcess
    {              
            
    static void Main()
        {
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine("ID: {0} Name: {1}", process.Id, process.ProcessName);
            }            
            Console.WriteLine("Если хотите убить процесс по Ид введите 1, по имени введите 2");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Введите ID");
                bool a = true;
                while (a)
                {
                    try
                    {
                        int id = Convert.ToInt32(Console.ReadLine());
                        Process chosen = Process.GetProcessById(id);
                        {
                            if (chosen.Id == Convert.ToInt32(id))
                            {
                                chosen.Kill();                                
                                a = false;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Нет такого ID");
                        continue;
                    }
                }
            }
            if (num == 2)
            {
                Console.WriteLine("Введите название процесса");
                bool a = true;
                while (a)
                {
                    try
                    {
                        string text = Console.ReadLine();
                        foreach (Process process in Process.GetProcesses())
                        {
                            if (process.ProcessName == text)
                            {
                                process.Kill();                                
                                a = false;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Нету такого процесса");
                        continue;
                    }
                }
            }
            else Console.WriteLine("Вы ввели неверное значение");
            
        }
    }
}