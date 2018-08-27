using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GENERIC_STACK
{
    class GenericLinkedListStack<T>
    {
        private Node first = null;

        private class Node
        {
            public T item;
            public Node next;
        }

        //method to check if the stack is empty or not
        public bool isEmpty()
        { return first == null; }

        //method to push an item into the stack
        public void Push(T item)
        {
            Node oldFirst = first;

            first = new Node();
            first.item = item;
            first.next = oldFirst;
        }

        //method to pop an item from the stack
        public T Pop()
        {
            T item = first.item;
            first = first.next;
            return item;
        }

        public static void Main()
        {
            GenericLinkedListStack<String> llStack = new GenericLinkedListStack<String>();

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
