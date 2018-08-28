using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GENERIC_STACK
{
    class GenericFixedArrayStack<T> : IEnumerable<T>
    {
        private T[] s;
        private int N = 0;

        //constructor to initialize the array with the defined size
        public GenericFixedArrayStack(int capacity)
        {
            s = new T[capacity];
        }

        //method to check if the stack is empty
        public bool isEmpty()
        { return N == 0; }

        //method to push an item into the stack
        public void Push(T item)
        {
            s[N++] = item;
        }

        //method to pop and item from the stack
        public T Pop()
        {
            T item = s[--N];
            s[N] = default(T); //set as null to avoid loitering
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = N - 1; i >= 0; i--)
            {
                yield return s[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static void Main()
        {
            GenericFixedArrayStack<String> faStack = new GenericFixedArrayStack<String>(10);

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
