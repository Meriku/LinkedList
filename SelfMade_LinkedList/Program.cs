using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMade_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Связный список 

            var linkedlist = new Model.LinkedList<int>();

            linkedlist.Add(1);
            linkedlist.Add(2);
            linkedlist.Add(3);
            linkedlist.Delete(3);

            Console.WriteLine("Связный список элементов:" + linkedlist.Count);


            // Стек (реализация через Linked)

            var stack = new Model.LinkedStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Peek();
            stack.Pop();

            Console.WriteLine("Стек элементов:" + stack.count);

            // Двусвязный список 

            var linkedDuplexList = new Model.DuplexLinkedList<int>();
            
            linkedDuplexList.Add(1);
            linkedDuplexList.Add(2);
            linkedDuplexList.Add(3);
            linkedDuplexList.Delete(3);

            Console.WriteLine("Двусвязный список элементов:" + linkedDuplexList.Count);

            Console.Read();

        }
    }
}
