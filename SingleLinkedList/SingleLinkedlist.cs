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
        Node<T> head;
        public Node<T> sorted;
        int count;
        public SingleLinkedList()
        {
            head = null;
        }

        public void insert(int newElement)
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

        public Node<T> get_node(int position)
        {
            if (position < 1)
            {
                return null;
            }
            else if (position == 1 && head != null)
            {
                return head;
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
                return temp;
            }
        }

        public bool delete_after(int position)
        {
            if (position < 1)
            {
                return false;
            }
            else if (position == 1 && head != null)
            {
                Node<T> nodeToDelete = head;
                head = head.next;
                nodeToDelete = null;
                count--;
                return true;
            }
            else
            {
                Node<T> temp = new Node<T>();
                temp = head;
                for (int i = 1; i < position; i++)
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
                    count--;
                    return true;
                }
                else
                {
                    return false;
                }
            }
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
                Console.Write("The list has ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There is nothing in the list");
            }
        }

        private void insert_first(int newElement)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = newElement;
            newNode.next = head;
            head = newNode;
            count++;
        }


        public class Node<T>
        {
            internal Node<T> next;
            internal int data;

            public static implicit operator Node<T>(Node v)
            {
                throw new NotImplementedException();
            }
        }

        public void Insert_beetwen(int newElement, int position, int count, Node<T>? head)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = newElement;
            newNode.next = null;

            if (position < 1)
            {
                Console.Write("\nposition >= 1.");
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
                    Console.Write("\nnode is null.");
                }
            }
            count++;
        }
        public void Insert_last(int newElement, int count, object head)
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
                temp = (Node<T>)head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newNode;
            }
            count++;
        }
    }

 }
