using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Xml.Linq;


namespace DatenstrukturenSingleLinkedList
{
    public class DatenstrukturenSingleLinkedList<T>
    {
        
            Node<T> head;
            public Node<T> sorted;
            int count;
            public DatenstrukturenSingleLinkedList()
            {
                head = null;
            }


            public void insert_inthemiddle(int newElement, int position)
            {
                Node<T> newNode = new Node<T>();
                newNode.data = newElement;
                newNode.next = null;

                if (position < 1)
                {
                    Console.Write("\nposition should be >= 1.");
                }
                else if (position == 1)
                {
                    newNode.next = head;
                    head = newNode;
                }
                else
                {

                    Node<T> temp = new Node<T>();
                    temp = head;
                    for (int i = 1; i < position - 1; i++)
                    {
                        if (temp != null)
                        {
                            temp = temp.next;
                        }
                    }

                    if (temp != null)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                    }
                    else
                    {
                        Console.Write("\nThe previous node is null.");
                    }
                }
                count++;
            }

            public void insert_AtTheEnd(int newElement)
            {
                Node<T> newNode = new Node<T>();
                newNode.data = newElement;
                newNode.next = null;
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node<T> temp = new Node<T>();
                    temp = head;
                    while (temp.next != null)
                        temp = temp.next;
                    temp.next = newNode;
                }
                count++;
            }

            public void delete_at(int position)
            {
                if (position < 1)
                {
                    Console.Write("\nposition should be >= 1.");
                }
                else if (position == 1 && head != null)
                {
                    Node<T> nodeToDelete = head;
                    head = head.next;
                    nodeToDelete = null;
                }
                else
                {
                    Node<T> temp = new Node<T>();
                    temp = head;
                    for (int i = 1; i < position - 1; i++)
                    {
                        if (temp != null)
                        {
                            temp = temp.next;
                        }
                    }
                    if (temp != null && temp.next != null)
                    {
                        Node<T> nodeToDelete = temp.next;
                        temp.next = temp.next.next;
                        nodeToDelete = null;
                    }
                    else
                    {
                        Console.Write("\nThe node is already null.");
                    }
                }
                count--;
            }

            public void delete_last()
            {
                if (this.head != null)
                {
                    if (this.head.next == null)
                    {
                        this.head = null;
                    }
                    else
                    {
                        Node<T> temp = new Node<T>();
                        temp = this.head;
                        while (temp.next.next != null)
                            temp = temp.next;
                        Node<T> lastNode = temp.next;
                        temp.next = null;
                        lastNode = null;
                    }
                }
                count--;
            }


            public int size()
            {
                return count;
            }

            public void PrintList()
            {
                Node<T> temp = new Node<T>();
                temp = this.head;
                if (temp != null)
                {
                    Console.Write("The list contains: ");
                    while (temp != null)
                    {
                        Console.Write(temp.data + " ");
                        temp = temp.next;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The list is empty.");
                }
            }
            void insertionSort(Node<T> headref)
            {
                sorted = null;
                Node<T> current = headref;

                while (current != null)
                {

                    Node<T> next = current.next;

                    sortedInsert(current);

                    // Update current
                    current = next;
                }
                head = sorted;
            }

            void sortedInsert(Node<T> newnode)
            {
                /* Special case for the head end */
                if (sorted == null || sorted.data >= newnode.data)
                {
                    newnode.next = sorted;
                    sorted = newnode;
                }
                else
                {
                    Node<T> current = sorted;

                    /* Locate the node before the point of insertion */
                    while (current.next != null &&
                            current.next.data < newnode.data)
                    {
                        current = current.next;
                    }
                    newnode.next = current.next;
                    current.next = newnode;
                }
            }
             public void insertionSort()
             {
                var temp = head.next;

                while (temp != null)
                {
                    for (var current = head; current.next != null; current = current.next)
                    {
                        if (current.data == temp.data && current.next.data == temp.next.data)
                            break;
                        if (current.data <= temp.data)
                            continue;
                        var save = current.data;
                        current.data = temp.data;
                        temp.data = save;
                    }
                    temp = temp.next;
                }
            }
        public void insertionSortinverse()
        {
            var temp = head;

            while (temp != null)
            {
                for (var current = head; current != null; current = current)
                {
                    if (current.data == temp.data && current.next.data == temp.next.data)
                        break;
                    if (current.data >= temp.data)
                        continue;
                    var save = current.data;
                    current.data = temp.data;
                    temp.data = save;
                }
                temp = temp.next;
            }
        }
    }
    }
