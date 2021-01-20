using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_2
{
    public class TwoLinkedList : ILinkedList
    {
        Node startNode;
        Node endNode;
        private int Count = 0;

        public void AddNode(int value)  // добавляет новый элемент в конец списка
        {
            var node = startNode;
            if (node != null)
            {
                while (node.NextNode != null)
                {
                    node = node.NextNode;
                }
                Node newNode = new Node { Value = value, PrevNode = node };
                node.NextNode = newNode;
                endNode = newNode;                
            }
            else
            {
                Node newNode = new Node { Value = value };
                startNode = newNode;
                endNode = newNode;                
            }
            Count++;
        }

        public void AddNodeAfter(Node node, int value) // добавляет новый элемент списка после определённого элемента
        {
            var searchNode = node;
            if (searchNode != null)
            {
                if (searchNode.NextNode != null)
                {
                    Node newNode = new Node { Value = value, PrevNode = searchNode, NextNode = searchNode.NextNode };
                    searchNode.NextNode = newNode;                    
                }
                else
                {
                    Node newNode = new Node { Value = value, PrevNode = searchNode };
                    searchNode.NextNode = newNode;
                    endNode = newNode;                   
                }
                Count++;
            }
            else Console.WriteLine("Такого элемента не существует");

        }

        public Node FindNode(int searchValue) // ищет элемент по его значению
        {
            var searchNode = startNode;
            for (int i = 0; i < Count - 1; i++)                        
            {
                if (searchValue == searchNode.Value)
                {
                    return searchNode;
                }
                searchNode = searchNode.NextNode;
            }
            Console.WriteLine("Элемент не найден");
            return null; 
        }

        public int GetCount() // Возращаем количество элементов в списке
        {            
            return Count;           
        }

        public void RemoveNode(int index) // удаляет элемент по порядковому номеру
        {
            if (index < 0 || index >= Count) throw new IndexOutOfRangeException(); 
            var node = startNode;
            if (Count == 0) return;
            if (index == 0)
            { 
              startNode.NextNode.PrevNode = null;
              startNode = startNode.NextNode;
              Count--;
            }
            if (index == Count - 1)
            {
                endNode.PrevNode.NextNode = null;
                endNode = endNode.PrevNode;
                Count--;
            }
            for (int i = 1; i < Count; i++)
            {
                node = node.NextNode;
                if (i == index)
                {                    
                    node.NextNode.PrevNode = node.PrevNode;
                    node.PrevNode.NextNode = node.NextNode;
                    Count--;
                    break;
                }
            }            
        }   

        public void RemoveNode(Node node) // удаляет указанный элемент
        {
            var searchNode = node;
            if (searchNode != null)
            {
                if (searchNode.NextNode != null && searchNode.PrevNode != null)
                {
                    searchNode.NextNode.PrevNode = searchNode.PrevNode;
                    searchNode.PrevNode.NextNode = searchNode.NextNode;                   
                }
                if (searchNode == startNode)
                {
                    searchNode.NextNode.PrevNode = null;
                    startNode = searchNode.NextNode;                    
                }
                if (searchNode == endNode)
                {
                    searchNode.PrevNode.NextNode = null;
                    endNode = searchNode.PrevNode;                    
                }
                Count--;
            }            
        }       
    }
}
