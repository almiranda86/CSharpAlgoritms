using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 50;
            int[] array = new int[] { 10, 20, 30, 40, 50, 60, 70 };
            BinarySearch binarySearch = new BinarySearch();
            var ret = binarySearch.Search(array, x);
        }
    }

    public class BinarySearch
    {
        /// <summary>
        /// Algorithm to Find the Position of a Given number X in an Unsorted Array
        /// </summary>
        /// <param name="array">
        /// The Array we want to search
        /// </param>
        /// <param name="x">
        /// The Value we want to find
        /// </param>

        public int Search(int[] array, int x)
        {
            ///The first index
            int p = 0;

            ///The last index of the Array
            int l = array.Length - 1;

            /// q - The midpoint of the Array
            int q = 0;

            while (p <= l)
            {
                q = (p + l) / 2;

                if (x < array[q])
                {
                    l = q - 1;
                }
                else if (x > array[q])
                {
                    p = q + 1;
                }
                else
                {
                    return q;
                }
            }

            ///Nothing was found...
            return -1;
        }
    }
}
