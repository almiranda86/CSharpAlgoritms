using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTest
{
    [TestClass]
    public class LinearSearch_Test
    {
        [TestMethod]
        public void Test1()
        {
            int x = 50;
            int[] array = new int[] { 10, 20, 30, 40, 50, 60, 70 };
            LinearSearch linearSearch = new LinearSearch();
            var ret = linearSearch.Search(array, x);

            Assert.Equals(ret, Array.IndexOf(array, x));
        }
    }
}
