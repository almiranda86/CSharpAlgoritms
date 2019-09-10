using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Algorithms;
using static System.Console;

namespace AlgorithmsTest
{
    [TestClass]
    public class Stack_Test
    {
        [TestMethod]
        public void Test1() {
            Stack theStack = new Stack(4);
            theStack.push("Star Wars 4");
            theStack.push("Star Wars 5");
            theStack.push("Star Wars 6");
            theStack.push("LotR");
            theStack.push("Rambo");

            WriteLine("=======\n About to peek: \n");
            WriteLine("'" + theStack.peek() + "'" + " is at the top of the stack");

            WriteLine("=======\n The Stack Contains: \n");
            while (!theStack.isEmpty())
            {
                string movie = theStack.pop();
                WriteLine(movie);
            }
            ReadKey();
        }
    }
}
