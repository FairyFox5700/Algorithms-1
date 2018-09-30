using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.QUICK_SORT
{
    class ThreeWayPartitioning
    {

        public static void Main()
        {
            int totalItems = 20;

            Console.WriteLine("STARTING THREE WAY PARTITIONING SORT");

            #region Initialize and Fill Array with Random Numbers
            IComparable[] arr = new IComparable[totalItems];

            Random rnd = new Random();

            for (int i = 0; i < totalItems; i++)
            {
                arr[i] = rnd.Next(1, 10);
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

            int lt = lo, gt = hi;
            IComparable v = a[lo];
            int i = lo;
            while(i<=gt)
            {
                int cmp = a[i].CompareTo(v);

                if (cmp < 0) exch(a, lt++, i++);
                else if (cmp > 0) exch(a, i, gt--);
                else i++;
            }

            sort(a, lo, lt - 1);
            sort(a, gt + 1, hi);
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
