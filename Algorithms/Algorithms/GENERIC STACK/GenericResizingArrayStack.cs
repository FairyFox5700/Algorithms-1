using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GENERIC_STACK
{
    class GenericResizingArrayStack<T> : IEnumerable<T>
    {
        private T[] s;
        private int N = 0;

        //constructor to initialize the array with the defined size
        public GenericResizingArrayStack()
        {
            s = new T[1];
        }

        //method to check if the stack is empty
        public bool isEmpty()
        { return N == 0; }

        //method to push an item into the stack
        public void Push(T item)
        {
            if (N == s.Length)
                resize(2 * s.Length);
            s[N++] = item;
        }

        //method to pop and item from the stack
        public T Pop()
        {
            T item = s[--N];
            s[N] = default(T); //set as null to avoid loitering

            if (N > 0 && N == s.Length / 4)
                resize(s.Length / 2);

            return item;
        }

        private void resize(int capacity)
        {
            T[] copy = new T[capacity];
            for (int i = 0; i < N; i++)
            {
                copy[i] = s[i];
            }

            s = copy;
        }

        public static void Main()
        {

            GenericResizingArrayStack<String> rsStack = new GenericResizingArrayStack<String>();

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
    }
}
