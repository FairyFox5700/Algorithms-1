using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.PRIORITY_QUEUES
{
    class UnorderedPriorityQueue
    {
        private static int[] pq;
        private int N;

        public UnorderedPriorityQueue(int capacity)
        {
            pq = new int[capacity];
        }

        public bool isEmpty()
        {
            return N == 0;
        }

        public void insert(int x)
        {
            pq[N++] = x;
        }

        public int delMax()
        {
            int max = 0;

            for (int i = 1; i < N; i++)
            {
                if (less(pq[max],pq[i]))
                {
                    max = i;
                }
            }
            exch(max, N - 1);

            pq[N - 1] = default(int);

            return pq[--N];
        }

        /// <summary>
        /// The method to exchange/swap the two numbers in the array
        /// </summary>
        /// <param name="a">The array in which swapping is required</param>
        /// <param name="i">The index of the first variable</param>
        /// <param name="j">The index of the second variable</param>
        private static void exch(int i, int j)
        {
            int swap = pq[i];
            pq[i] = pq[j];
            pq[j] = swap;
        }

        /// <summary>
        /// The method to compare if the first value is less or not
        /// </summary>
        /// <param name="v">The first number - which we have to compare</param>
        /// <param name="w">The second number - against which we have to compare</param>
        /// <returns>Returns true is first number is small else false</returns>
        private static bool less(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        public static void Main()
        { }
    }
}
