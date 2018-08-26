using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.STACK
{
    class FixedArrayStack
    {
        private string[] s;
        private int N = 0;

        //constructor to initialize the array with the defined size
        public FixedArrayStack(int capacity)
        {
            s = new string[capacity];
        }

        //method to check if the stack is empty
        public bool isEmpty()
        { return N == 0; }

        //method to push an item into the stack
        public void Push(string item)
        {
            s[N++] = item;
        }

        //method to pop and item from the stack
        public string Pop()
        {
            string item = s[--N];
            s[N] = null; //set as null to avoid loitering
            return item;
        }

        public static void Main()
        {
            FixedArrayStack faStack = new FixedArrayStack(10);

            faStack.Push("A");
            faStack.Push("B");
            faStack.Push("C");
            faStack.Push("D");

            faStack.Pop();
            faStack.Pop();
            faStack.Pop();

            faStack.Push("D");
            faStack.Push("C");
            faStack.Push("B");

            Console.ReadLine();
        }
    }
}
