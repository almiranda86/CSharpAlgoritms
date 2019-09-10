using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Algorithms;

namespace AlgorithmsTest
{
    [TestClass]
    public class Queue_Test
    {
        [TestMethod]
        public void Test1() {
            Queue queue = new Queue(5);
            queue.insert(100);
            queue.insert(10);
            queue.insert(200);
            queue.insert(300);
            queue.view();

            Console.WriteLine($"Front of the queue is {queue.peekFront()} ");

            Console.WriteLine($"About to remove...");
            queue.remove();
            Console.WriteLine($"Front of the queue is {queue.peekFront()} ");

            Console.ReadKey();
        }
    }
}
