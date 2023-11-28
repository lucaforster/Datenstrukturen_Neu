using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Baum
{
    public class BinaererBaum
    {
        Node? wurzel;

        public void addNode(int data)
        {
            var added = false;
            var cur = wurzel;
            if (wurzel == null)
            {
                wurzel = new Node(data);
                return;
            }
            while (added != true)
            {
                if(cur.data < data && cur.right == null)
                {
                    cur.right = new Node(data);
                    added = true;
                    return;
                }
                if (cur.data > data && cur.left == null)
                {
                    cur.left = new Node(data);
                    added = true;
                    return ;
                }
                if (cur.data < data && cur.right != null)
                {
                    cur = cur.right;
                }
                if(cur.data > data && cur.left != null)
                {
                    cur = cur.left;
                }
                if(cur.data == data)
                {
                    throw new Exception("Node already Exists");
                }
            } 
        }
