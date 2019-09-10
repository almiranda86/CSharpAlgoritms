using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Queue
    {
        private int maxSize;
        private long[] myQueue;
        private int front;
        private int rear;
        private int items;

        public Queue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            front = 0;
            rear = -1;
            items = 0;
        }

        public void insert(long value)
        {
            if (isFull())
            {
                Console.WriteLine();
            }
            else
            {
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }
                rear++;
                myQueue[rear] = value;
                items++;
            }
        }


        public long remove()
        {
            long temp = myQueue[front];
            front++;

            if (front == maxSize)
            {
                front = 0;
            }

            return temp;
        }


        public long peekFront()
        {
            return myQueue[front];
        }


        public void view()
        {
            Console.Write("[");
            for(int i = 0; i< myQueue.Length; i++)
            {
                Console.Write(myQueue[i] + " ");
            }
             Console.WriteLine("]");
        }

        public bool isEmpty()
        {
            return (items == 0);
        }

        private bool isFull()
        {
            return (items == maxSize);
        }
    }
}
