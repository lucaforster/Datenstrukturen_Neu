using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baum
{
    public class Node
    {
        public int data;
        public Node? left;
        public Node? right;

        public Node(int data)
        {
            this.data = data;
        }
        public Node() { }

        public bool isLeaf()
        {
            if (right == null && left == null)
            {
                return true;
            }
            return false;
        }
    }
}