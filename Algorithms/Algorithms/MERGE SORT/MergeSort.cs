using System;

namespace Algorithms.MERGE_SORT
{
    class MergeSort
    {
        private const int CUTOFF = 7;

        public static void Main()
        {
            int totalItems = 20;

            Console.WriteLine("STARTING MERGE SORT");

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
        private static void sort(IComparable[] a)
        {
            IComparable[] aux = new IComparable[a.Length];

            sort(a, aux, 0, a.Length - 1);
        }

        /// <summary>
        /// The method is used to break the array into two subarrays from mid and then sort them
        /// </summary>
        /// <param name="a">The array we have to sort</param>
        /// <param name="aux">The auxiliary array to help in sorting</param>
        /// <param name="lo">The lowest index number of the array to sort</param>
        /// <param name="hi">The highest index number of the array to sort</param>
        private static void sort(IComparable[] a, IComparable[] aux, int lo, int hi)
        {
            #region Improvisation #1 : Use of Insertion sort for small subarrays
            //if (hi <= lo) return; 
            if(hi <= lo + CUTOFF - 1)
            {
                SORTING.InsertionSort.sort(a, lo, hi);
                return;
            }

            #endregion

            //find the mid point of the array
            int mid = lo + (hi - lo) / 2;

            //Sort the first half of the array
            sort(a, aux, lo, mid);

            //Sort the second half of the array
            sort(a, aux, mid + 1, hi);

            #region Improvisation #2: Stop if the array is already sorted
            //By checking if the first element of second subarray is larger than the last element of first subarray
            if (!less(a[mid + 1], a[mid])) return; 
            #endregion

            merge(a, aux, lo, mid, hi);
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
            //Copy the elements of array a into array aux
            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }

            int i = lo, j = mid + 1;

            //Compare and merge the sorted subarray in two halves of array
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                    a[k] = aux[j++];
                else if (j > hi)
                    a[k] = aux[i++];
                else if (less(aux[j], aux[i]))
                    a[k] = aux[j++];
                else
                    a[k] = aux[i++];
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
