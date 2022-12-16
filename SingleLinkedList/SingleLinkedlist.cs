using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Xml.Linq;


namespace DatenstrukturenSingleLinkedList
{
    public class SingleLinkedList<T>
    {
        
            Node head;
            public Node sorted;
            int count;
            public SingleLinkedList()
            {
                head = null;
            }

        public void DeleteFirst()
        {
            count--;
            head = head.next;
        }

        public Node GetFirst()
        {
            return head;
        }

        public void insert_inthemiddle(int newElement, int position)
            {
                Node newNode = new Node();
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

                    Node temp = new Node();
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
                Node newNode = new Node();
                newNode.data = newElement;
                newNode.next = null;
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node temp = new Node();
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
                    Node nodeToDelete = head;
                    head = head.next;
                    nodeToDelete = null;
                }
                else
                {
                    Node temp = new Node();
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
                        Node nodeToDelete = temp.next;
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
                        Node temp = new Node();
                        temp = this.head;
                        while (temp.next.next != null)
                            temp = temp.next;
                        Node lastNode = temp.next;
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
                Node temp = new Node();
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
            void insertionSort(Node headref)
            {
                sorted = null;
                Node current = headref;

                while (current != null)
                {

                    Node next = current.next;

                    sortedInsert(current);

                    // Update current
                    current = next;
                }
                head = sorted;
            }

            void sortedInsert(Node newnode)
            {
                if (sorted == null || sorted.data >= newnode.data)
                {
                    newnode.next = sorted;
                    sorted = newnode;
                }
                else
                {
                Node current = sorted;
                    while (current.next != null &&
                            current.next.data < newnode.data)
                    {
                        current = current.next;
                    }
                    newnode.next = current.next;
                    current.next = newnode;
                }
            }
             public void insertionSortinverse()
             {
                var sort = head.next;

                while (sort != null)
                {
                    for (var current = head; current.next != null; current = current.next)
                    {
                        if (current.data == sort.data && current.next.data == sort.next.data)
                            break;
                        if (current.data <= sort.data)
                            continue;
                        var save = current.data;
                        current.data = sort.data;
                        sort.data = save;
                    }
                    sort = sort.next;
                }
            }
        public void insertionSort()
        {
            var sort = head;

            while (sort != null)
            {
                for (var current = head; current.next != null; current = current.next)
                {
                    if (current.data == sort.data && current.next.data == sort.next.data)
                        break;
                    if (current.data >= sort.data)
                        continue;
                    var save = current.data;
                    current.data = sort.data;
                    sort.data = save;
                }
                sort = sort.next;
            }
        }

        public Node? GetLast()
        {
            for (Node cur = head; cur.next != null; cur = cur.next)
            {
                if (cur.next == null)
                {
                    return cur;
                }
            }
            return null;
        }
        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            sortstrategy = sortStrategy;
        }

        public void Sort()
        {
            sortstrategy.Sort(this);
        }

        public void SortDesc()
        {
            sortstrategy.SortDesc(this);
        }
    }
    }
