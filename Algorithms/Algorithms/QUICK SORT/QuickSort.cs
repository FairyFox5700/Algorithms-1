using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.QUICK_SORT
{
    class QuickSort
    {
        public static void Main()
        {
            int totalItems = 20;

            Console.WriteLine("STARTING QUICK SORT");

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
        /// <param name="a">The array in which partition is required</param>
        public static void sort(IComparable[] a)
        {
            sort(a, 0, a.Length - 1);
        }

        /// <summary>
        /// The method to recursively partition and sort the array
        /// </summary>
        /// <param name="a">The array in which partition is required</param>
        /// <param name="lo">The index of the first variable</param>
        /// <param name="hi">The index of the last variable</param>
        public static void sort(IComparable[] a, int lo, int hi)
        {
            if (hi <= lo) return;
            int j = partition(a, lo, hi);

            sort(a, lo, j - 1);
            sort(a, j + 1, hi);
        }

        /// <summary>
        /// The method to partition the array in such a order that
        /// All the elements lower than the partition element are in the left
        /// All the element higher than the partition element are in the right
        /// </summary>
        /// <param name="a">The array in which partition is required</param>
        /// <param name="lo">The index of the first variable</param>
        /// <param name="hi">The index of the last variable</param>
        /// <returns>The method returns the index of the partition element</returns>
        private static int partition(IComparable[] a, int lo, int hi)
        {
            int i = lo, j = hi+1;

            while(true)
            {
                while (less(a[++i], a[lo]))
                    if (i == hi) break;

                while (less(a[lo], a[--j]))
                    if (j == lo) break;

                if (i >= j) break;
                exch(a, i, j);
            }

            exch(a, lo, j);

            return j;
        }

        /// <summary>
        /// The method to exchange/swap the two numbers in the array
        /// </summary>
        /// <param name="a">The array in which swapping is required</param>
        /// <param name="i">The index of the first variable</param>
        /// <param name="j">The index of the second variable</param>
        private static void exch(IComparable[] a, int i, int j)
        {
            IComparable swap = a[i];
            a[i] = a[j];
            a[j] = swap;
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
