using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace HomeWork_5_5._2
{
    

    public class ToDo
    {
        public string Title { set; get; }
        public string IsDone { set; get; }

        public ToDo(string title, string isdone)
        {
            Title = title;
            IsDone = isdone;
        }
    }
    
}
