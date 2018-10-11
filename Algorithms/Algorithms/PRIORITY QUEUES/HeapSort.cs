using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.PRIORITY_QUEUES
{
    class HeapSort
    {
        /// <summary>
        /// The array to hold the data of binary heap
        /// </summary>
        private int[] pq;

        /// <summary>
        /// The variable indicates the last element of the priority queue in array
        /// </summary>
        private int N;

        /// <summary>
        /// The constructor to define the array for Heap Sort
        /// </summary>
        /// <param name="capacity">The capacity or length of the array for the Binary Sort</param>
        public HeapSort(int capacity)
        {
            pq = new int[capacity + 1];
        }

        /// <summary>
        /// Method to insert a new element in the binary heap
        /// </summary>
        /// <param name="key">The element to insert in the binary heap</param>
        public void insert(int key)
        {
            pq[++N] = key;
        }

        /// <summary>
        /// Method is used to demote an element in the binary heap
        /// The method is used to validate if the parent value is not less than it's children.
        /// </summary>
        /// <param name="removeAt">The index of the parent node to validate</param>
        /// <param name="totalElement">The total number of elements in the heap</param>
        private void sink(int removeAt, int totalElement )
        {
            while(2*removeAt <= totalElement)
            {
                int j = 2 * removeAt;

                if (j < N && less(j, j + 1)) j++;

                if (!less(removeAt, j)) break;

                exch(removeAt, j);

                removeAt = j;
            }
        }

        /// <summary>
        /// Method to sort the heap tree
        /// </summary>
        public void sort()
        {
            for (int k = N/2; k >= 1; k--)
            {
                sink(k, N);
            }

            while(N>1)
            {
                exch(1, N);
                sink(1, --N);
            }

        }

        /// <summary>
        /// The method to compare if the first value is less or not
        /// </summary>
        /// <param name="v">The first index of node - which we have to compare</param>
        /// <param name="w">The second index of node - against which we have to compare</param>
        /// <returns>Returns true is first number is small else false</returns>
        private bool less(int i, int j)
        {
            return pq[i].CompareTo(pq[j]) < 0;
        }

        /// <summary>
        /// The method to exchange/swap the two numbers in the binary heap array
        /// </summary>
        /// <param name="i">The index of the first node</param>
        /// <param name="j">The index of the second node</param>
        private void exch(int i, int j)
        {
            int temp = pq[i];
            pq[i] = pq[j];
            pq[j] = temp;
        }

        /// <summary>
        /// The method to print the binary heap array
        /// </summary>
        private void printArray()
        {
            string holdValue = string.Empty;

            for (int i = 1; i < pq.Count(); i++)
            {
                if (i == 1)
                    holdValue += pq[i].ToString();
                else
                    holdValue += ", " + pq[i].ToString();
            }

            Console.WriteLine(holdValue);
        }

        public static void Main()
        {
            int capacity = 20;

            Console.WriteLine("STARTING HEAP SORT");

            HeapSort heapSort = new HeapSort(capacity);

            Random random = new Random();

            for (int i = 0; i < capacity; i++)
            {
                int rnd = random.Next(1, 50);

                heapSort.insert(rnd);
            }

            #region The Binary Heap After Insertion
            Console.WriteLine("The heap after insertions: ");
            heapSort.printArray();
            #endregion

            heapSort.sort();

            #region The Binary Heap After Deletion
            Console.WriteLine("The binary heap after sorting: ");
            heapSort.printArray();
            #endregion

            Console.ReadKey();
        }
    }
}
