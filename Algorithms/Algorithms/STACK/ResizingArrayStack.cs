using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.STACK
{
    class ResizingArrayStack
    {
        private string[] s;
        private int N = 0;

        //constructor to initialize the array with the defined size
        public ResizingArrayStack()
        {
            s = new string[1];
        }

        //method to check if the stack is empty
        public bool isEmpty()
        { return N == 0; }

        //method to push an item into the stack
        public void Push(string item)
        {
            if (N == s.Length)
                resize(2 * s.Length);
            s[N++] = item;
        }

        //method to pop and item from the stack
        public string Pop()
        {
            string item = s[--N];
            s[N] = null; //set as null to avoid loitering

            if (N > 0 && N == s.Length / 4)
                resize(s.Length / 2);

            return item;
        }

        private void resize(int capacity)
        {
            string[] copy = new string[capacity];
            for (int i = 0; i < N; i++)
            {
                copy[i] = s[i];
            }

            s = copy;
        }

        public static void Main()
        {

            ResizingArrayStack rsStack = new ResizingArrayStack();

            rsStack.Push("A");
            rsStack.Push("B");
            rsStack.Push("C");
            rsStack.Push("D");

            rsStack.Pop();
            rsStack.Pop();
            rsStack.Pop();

            rsStack.Push("D");
            rsStack.Push("C");
            rsStack.Push("B");
            rsStack.Push("B");
            rsStack.Push("B");
            rsStack.Push("B");

            Console.ReadLine();
        }
    }
}
