using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_5._1
{
    /// <summary>
    /// Класс описывающий задачи
    /// </summary>
    public class ToDo
    {
        public string Title { get; set; }

        public bool IsDone { get; set; }
                
        public ToDo(string title, bool isdone = false)
        {
            IsDone = isdone;
            Title = title;            
        }
        /// <summary>
        /// Вывод задачи на консоль
        /// </summary>
        public void Print(int i)
        {
            string status = IsDone ? "[x]" : "[ ]";
            string output = String.Format("{0}\t {1}\t\t{2}",i, status, Title);
            Console.WriteLine(output);
        }
        /// <summary>
        /// Добавление новой задачи
        /// </summary>
        /// <returns></returns>
        public static ToDo CreateNewTask()
        {            
            Console.WriteLine("\nВведите название задачи");           
            return new ToDo(Console.ReadLine());
        }
        /// <summary>
        /// Меняем задачу
        /// </summary>
        public void  ChangeTitle()
        {
            Console.WriteLine("\nВведите новое название задачи");
            Title = Console.ReadLine();
        }
        /// <summary>
        /// Изменяем статус с false на true
        /// </summary>
        public void ChangeStatus()
        {
            IsDone = !IsDone;
        }
        /// <summary>
        /// Конструктор для десерилизаци
        /// </summary>
        public ToDo()
        {

        }
    }
}
