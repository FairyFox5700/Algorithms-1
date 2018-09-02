using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SORTING
{
    class SelectionSort
    {
        public static void Main()
        {
            int totalItems = 20;
            string holdValue = string.Empty;

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
            for (int i = 0; i < totalItems; i++)
            {
                holdValue += arr[i].ToString() + ", ";
            }
            Console.WriteLine(holdValue);
            holdValue = string.Empty;
            #endregion

            #region Perform Sorting Operation
            Console.WriteLine("\nSorting Array...");
            sort(arr);
            Console.WriteLine("\nSorting Completed!");
            #endregion


            #region Print Sorted Array
            Console.WriteLine("\nThe array after sorting: ");

            for (int i = 0; i < totalItems; i++)
            {
                holdValue += arr[i].ToString() + ", ";
            }

            Console.WriteLine(holdValue); 
            #endregion

            Console.ReadLine();
        }

        /// <summary>
        /// The method to sort the array using the Selection Sort implementation
        /// </summary>
        /// <param name="a">The array to be sorted</param>
        private static void sort(IComparable[] a)
        {
            int N = a.Length;

            for (int i = 0; i < N; i++)
            {
                int min = i;
                for (int j = i+1; j < N; j++)
                {
                    if(less(a[j], a[min]))
                    {
                        min = j;
                    }
                }

                exch(a, i, min);
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
    }
}
