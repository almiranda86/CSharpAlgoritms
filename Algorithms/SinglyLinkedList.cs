using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class SinglyLinkedList
    {
        private Node first;

        /// <summary>
        /// check if the fisrt Node is empty
        /// check if the fisrt Node points to null
        /// this way, we know that we don't have any nodes
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return (first == null);
        }

        /// <summary>
        /// This method inserts the First Node
        /// So, we're assign the data passed to the Node
        /// and them, assign the new Node next property shoul point to the First
        /// </summary>
        /// <param name="data"></param>
        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }

        /// <summary>
        /// Remove the first node of a list
        /// </summary>
        /// <returns></returns>
        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }

        /// <summary>
        /// Display the Nodes contents
        /// </summary>
        public void displayList()
        {
            Console.WriteLine("List (first -- last) ");
            Node currentNode = first;

            while (currentNode != null)
            {
                currentNode.displayNode();
                currentNode = currentNode.next;
            }

            Console.WriteLine(" ");
        }

        /// <summary>
        /// This method inserts the First Node
        /// So, we're assign the data passed to the Node
        /// and them, assign the new Node next property shoul point to the First
        /// </summary>
        /// <param name="data"></param>
        public void insertLast(int data)
        {
            Node currentNode = first;
            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            currentNode.next = newNode;
        }
    }


    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }
}
