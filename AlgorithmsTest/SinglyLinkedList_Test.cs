using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTest
{
    [TestClass]
    public class SinglyLinkedList_Test
    {
        [TestMethod]
        public void Test1()
        {
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.insertFirst(100);
            singlyLinkedList.insertFirst(50);
            singlyLinkedList.insertFirst(1);
            singlyLinkedList.insertFirst(25);
            singlyLinkedList.insertLast(999000);
            singlyLinkedList.displayList();

            singlyLinkedList.deleteFirst();
            singlyLinkedList.displayList();

            Console.ReadKey();
        }
    }
}
