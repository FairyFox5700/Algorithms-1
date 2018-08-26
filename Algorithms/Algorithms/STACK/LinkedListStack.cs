using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.STACK
{
    class LinkedListStack
    {
        private Node first = null;

        private class Node
        {
            public string item;
            public Node next;
        }

        //method to check if the stack is empty or not
        public bool isEmpty()
        { return first == null; }

        //method to push an item into the stack
        public void Push(string item)
        {
            Node oldFirst = first;

            first = new Node();
            first.item = item;
            first.next = oldFirst;
        }

        //method to pop an item from the stack
        public string Pop()
        {
            string item = first.item;
            first = first.next;
            return item;
        }

        public static void Main()
        {
            LinkedListStack llStack = new LinkedListStack();

            llStack.Push("A");
            llStack.Push("B");
            llStack.Push("C");
            llStack.Push("D");

            llStack.Pop();
            llStack.Pop();
            llStack.Pop();

            Console.ReadLine();
        }
    }
}
