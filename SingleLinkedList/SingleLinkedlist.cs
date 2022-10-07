using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenstrukturenSingleLinkedList
{
        public class SingleLinkedList
        {
            Node head;
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
            public int size()
            {
                return count;
            }
        }
    }