using System;

namespace Algorithms.MERGE_SORT
{
    class BottomUpMergeSort
    {
        public static void Main()
        {
            int totalItems = 20;

            Console.WriteLine("STARTING BOTTOM UP MERGE SORT");

            #region Initialize and Fill Array with Random Numbers
            IComparable[] arr = new IComparable[totalItems];

            Random rnd = new Random();

            for (int i = 0; i < totalItems; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
            #endregion

            #region Print Unsorted Array
            Console.WriteLine("The array before sorting: ");
            printArray(arr, totalItems);
            #endregion

            #region Perform Sorting Operation
            Console.WriteLine("\nSorting Array...");
            sort(arr);
            Console.WriteLine("\nSorting Completed!");
            #endregion

            #region Print Sorted Array
            Console.WriteLine("\nThe array after sorting: ");
            printArray(arr, totalItems);
            #endregion

            Console.ReadLine();
        }

        /// <summary>
        /// The method to sort the array
        /// </summary>
        /// <param name="a">The array we have to sort</param>
        public static void sort(IComparable[] a)
        {
            int N = a.Length;

            IComparable[] aux = new IComparable[N];

            for (int sz = 1; sz < N; sz = sz+sz)
            {
                for (int lo = 0; lo < N - sz; lo+= sz+sz)
                {
                    merge(a, aux, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, N - 1));
                }

            }
        }

        /// <summary>
        /// The method compare and merge the two sorted sub arrays
        /// </summary>
        /// <param name="a">The array we have to sort</param>
        /// <param name="aux">The auxiliary array to help in sorting</param>
        /// <param name="lo">The lowest index number of the array to sort</param>
        /// <param name="mid">The middle index number of the array to sort</param>
        /// <param name="hi">The highest index number of the array to sort</param>
        private static void merge(IComparable[] a, IComparable[] aux, int lo, int mid, int hi)
        {
            for (int k = lo; k <= hi; k++)
                aux[k] = a[k];

            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                    a[k] = aux[j++];
                else if (j > hi)
                    a[k] = aux[i++];
                else if (less(aux[i], aux[j]))
                    a[k] = aux[i++];
                else
                    a[k] = aux[j++];
            }
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

        /// <summary>
        /// The method to print the array
        /// </summary>
        /// <param name="a">The array we need to print</param>
        /// <param name="totalItems">The total number of elements in the array</param>
        private static void printArray(IComparable[] a, int totalItems)
        {
            string holdValue = string.Empty;

            for (int i = 0; i < totalItems; i++)
            {
                if (i == 0)
                    holdValue += a[i].ToString();
                else
                    holdValue += ", " + a[i].ToString();
            }

            Console.WriteLine(holdValue);
        }
    }
}
