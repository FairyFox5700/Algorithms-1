using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.QUEUE
{
    class LinkedListQueue
    {
        private Node first, last = null;

        private class Node
        {
            public string item;
            public Node next;
        }

        //method to check if the queue is empty
        public bool isEmpty()
        { return first == null; }

        //method to enqueue the element in queue
        public void Enqueue(string item)
        {
            Node oldLast = last;

            last = new Node();
            last.item = item;
            last.next = null;

            if (isEmpty()) first = last;
            else
                oldLast.next = last;
        }

        //method to dequeue the element from the queue
        public string Dequeue()
        {
            string item = first.item;
            first = first.next;

            if (isEmpty()) last = null;

            return item;
        }

        public static void Main()
        {
            LinkedListQueue llQueue = new LinkedListQueue();

            llQueue.Enqueue("A");
            llQueue.Enqueue("B");
            llQueue.Enqueue("C");
            llQueue.Enqueue("D");

            llQueue.Dequeue();
            llQueue.Dequeue();
            llQueue.Dequeue();

            llQueue.Enqueue("D");
            llQueue.Enqueue("C");
            llQueue.Enqueue("B");
            llQueue.Enqueue("B");
            llQueue.Enqueue("B");
            llQueue.Enqueue("B");

            Console.ReadLine();
        }
    }
}
