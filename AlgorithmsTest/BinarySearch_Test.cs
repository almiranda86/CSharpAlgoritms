using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Algorithms;

namespace AlgorithmsTest
{
    [TestClass]
    public class BinarySearch_Test
    {
        [TestMethod]
        public void Test1()
        {
            int x = 50;
            int[] array = new int[] { 10, 20, 30, 40, 50, 60, 70 };
            BinarySearch binarySearch = new BinarySearch();
            var ret = binarySearch.Search(array, x);
            
            Assert.Equals(ret, Array.BinarySearch(array, x));
        }
    }
}
