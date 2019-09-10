using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Algorithms
{
    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }


        public void push(string value)
        {
            if (isFull())
            {
                WriteLine("The stack is full");
            }
            else
            {
                top++;
                stackArray[top] = value;
            }
        }


        public string pop()
        {
            if (isEmpty())
            {
                WriteLine("The stack is empty");
                return "--";
            }
            else
            {
                int old_top = top;
                top--;
                return stackArray[old_top];
            }
        }


        public string peek()
        {
            return stackArray[top];
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        public bool isFull()
        {
            return (maxSize - 1 == top);
        }
    }
}
