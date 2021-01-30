using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.AddLeavesRec(100);
            tree.AddLeavesRec(110);
            tree.AddLeavesRec(108);
            tree.AddLeavesRec(111);
            tree.AddLeavesRec(50);
            tree.AddLeavesRec(60);
            tree.AddLeavesRec(45);
            tree.AddLeavesRec(46);
        }
    }
}
