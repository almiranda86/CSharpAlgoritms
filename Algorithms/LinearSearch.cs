using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class LinearSearch
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
            int answer = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    return i;

                }
            }

            return -1;
        }
    }
}
