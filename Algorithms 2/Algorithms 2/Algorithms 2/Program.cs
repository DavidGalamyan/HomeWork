using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoLinkedList list = new TwoLinkedList();
            list.AddNode(21);
            list.AddNode(11);
            list.AddNode(2);
            for (int i = 0; i < list.GetCount(); i++)
            {
                
            }
            list.FindNode(11);
            list.RemoveNode(list.FindNode(21));
            for (int i = 0; i < list.GetCount(); i++)
            {
                
            }
            list.AddNodeAfter(list.FindNode(11), 57);
        }
    }
}
