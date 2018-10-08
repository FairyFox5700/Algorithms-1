using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.PRIORITY_QUEUES
{
    class BinaryHeap
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
        /// The constructor to define the array for Binary Heap
        /// </summary>
        /// <param name="capacity">The capacity or length of the array for the Binary Heap</param>
        public BinaryHeap(int capacity)
        {
            pq = new int[capacity + 1];
        }

        /// <summary>
        /// Method to check whether the binary heap is empty or not
        /// </summary>
        /// <returns>If the binary heap is empty then returns true else false</returns>
        public bool isEmpty()
        {
            return N == 0;
        }

        /// <summary>
        /// Method to insert a new element in the binary heap
        /// </summary>
        /// <param name="key">The element to insert in the binary heap</param>
        public void insert(int key)
        {
            pq[++N] = key;
            swim(N);
        }

        /// <summary>
        /// Method to delete the maximum value element (i.e root element) from the binary heap
        /// </summary>
        /// <returns>The deleted element from the binary heap</returns>
        public int delMax()
        {
            int max = pq[1];

            exch(1, N--);

            sink(1);

            pq[N + 1] = default(int);

            return max;
        }

        /// <summary>
        /// Method to promote an element in the binary heap
        /// The method is used to validate if the child key is not greater than it's parent
        /// </summary>
        /// <param name="k">The index of the child node to validate</param>
        private void swim(int k)
        {
            while (k > 1 && less(k / 2, k))
            {
                exch(k, k / 2);
                k = k / 2;
            }
        }

        /// <summary>
        /// Method is used to demote an element in the binary heap
        /// The method is used to validate if the parent value is not less than it's children.
        /// </summary>
        /// <param name="k">The index of the parent node to validate</param>
        private void sink(int k)
        {
            while (2 * k <= N) 
            {
                int j = 2 * k;

                //Get the highest value children of k i.e. 2k & 2k+1
                if (j < N && less(j, j + 1))
                    j++;

                if (!less(k, j))
                    break;

                exch(j, k);

                k = j;
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

            Console.WriteLine("STARTING BINARY HEAP");

            BinaryHeap binaryHeap = new BinaryHeap(capacity);

            Random random = new Random();

            for (int i = 0; i < capacity; i++)
            {
                int rnd = random.Next(1, 50);

                binaryHeap.insert(rnd);

                #region The Binary Heap After Insertion
                Console.WriteLine("The binary heap after inserting {0}: ", rnd);
                binaryHeap.printArray();
                #endregion
            }

            #region The Binary Heap After Insertion
            Console.WriteLine("The binary heap after insertions: ");
            binaryHeap.printArray();
            #endregion

            for (int i = 0; i < 5; i++)
            {
                int delete = binaryHeap.delMax();

                #region The Binary Heap After Deletion
                Console.WriteLine("The binary heap after deletion of {0}: ", delete);
                binaryHeap.printArray();
                #endregion
            }

            #region The Binary Heap After Deletion
            Console.WriteLine("The binary heap after deletions: ");
            binaryHeap.printArray();
            #endregion

            Console.ReadKey();
        }
    }
}
