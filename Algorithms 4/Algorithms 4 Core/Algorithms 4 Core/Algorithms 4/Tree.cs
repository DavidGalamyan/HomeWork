using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_4
{
    public class Tree
    {
        public static Node Root;
        private int count = 0;        
        public void AddLeavesRec(int value)
        {
            if (Root == null)
            {
                Root = new Node { Data = value };
                count++;
            }
            else
            {
                AddLeavesRec(value, Root);
            }
        }
        private void AddLeavesRec(int value, Node node)
        {
            if (node.Data > value)
            {
                if (node.Left != null)
                {
                    AddLeavesRec(value, node.Left);
                }
                else
                {
                    node.Left = new Node { Data = value, Parent = node };
                    count++;
                }
            }
             if (node.Data < value)
             {
                if (node.Right != null)
                {
                    AddLeavesRec(value, node.Right);
                }
                else
                {
                    node.Right = new Node { Data = value, Parent = node };
                    count++;
                }
             }            
        }
    }
}
