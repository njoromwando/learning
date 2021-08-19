using System;
using System.Threading;

namespace DataStractures
{
    public class Node
    {
        public int element;
        public Node next;

        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }

    internal class LinkedList
    {
        // member variables
        private Node head;

        private Node tail;
        private int size;  // keep tract of our linked list size.

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Length() => size;

        public bool IsEmpty() => size == 0;

        public void AddLast(int e)
        {
            var newest = new Node(e, null);
            if (IsEmpty())
            {
                head = newest;
            }
            else
            {
                tail.next = newest;
            }

            tail = newest;
            size += 1;
        }

        public void AddFirst(int e)
        {
            var newNode = new Node(e, null);
            // check if the list is empty
            if (IsEmpty())
            {
                // for an empty list
                // add the new node to the head.

                head = newNode;
                // assign tail to the new node.
                tail = newNode;
            }
            else
            {
                // if list contains elements
                // set new node to point to the current head.
                newNode.next = head;
                // make the new node the head.
                head = newNode;
            }
            // increment size
            size += 1;
        }

        public void display()
        {
            var p = head;
            while (p != null)
            {
                Console.Write(p.element + " : ");
                p = p.next;
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var linkedJames = new LinkedList();
            var number = new int[] { 4, 6, 7, 8, 9, 0, 6, 4, 7 };

            foreach (var item in number)
            {
                linkedJames.AddLast(item);
            }

            linkedJames.display();
            Console.WriteLine("Linked List size is:  {0}", linkedJames.size);

            Console.WriteLine("Adding element at the start of the list");

            linkedJames.AddFirst(897);

            linkedJames.display();
            Console.WriteLine("Linked List size now is:  {0}", linkedJames.size);
            Console.ReadKey();
        }
    }
}