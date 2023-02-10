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
                if (cur.data < data && cur.right == null)
                {
                    cur.right = new Node(data);
                    added = true;
                    return;
                }
                if (cur.data > data && cur.left == null)
                {
                    cur.left = new Node(data);
                    added = true;
                    return;
                }
                if (cur.data < data && cur.right != null)
                {
                    cur = cur.right;
                }
                if (cur.data > data && cur.left != null)
                {
                    cur = cur.left;
                }
                if (cur.data == data)
                {
                    throw new Exception("Node already Exists");
                }
            }
        }

        public void deleteNode(int data)
        {
            var cur = FindeNode(data);

            if (wurzel != null && wurzel.left == null && wurzel.right == null)
            {
                wurzel = null;
            }
            else if (cur.isLeaf())
            {
                deleteLeaf(cur);
            }
            else
            {
                deleteintheMiddle(cur);
            }
        }

        private void deleteLeaf(Node leaf)
        {
            setPrevChildNode(leaf, null);
        }

        private void setPrevChildNode(Node startNode, Node? replaceNode)
        {
            Node prevNode = GetPreviousNode(startNode);
            if (prevNode.left != null)
                if (prevNode.left.data == startNode.data)
                    prevNode.left = replaceNode;

            if (prevNode.right != null)
                if (prevNode.right.data == startNode.data)
                    prevNode.right = replaceNode;
        }
        private void deleteintheMiddle(Node nodeToDelete)
        {
            if (nodeToDelete.right == null || nodeToDelete.left == null)
            {
                Node nodeToReplace;
                if (nodeToDelete.left == null)
                    nodeToReplace = nodeToDelete.right;
                else
                    nodeToReplace = nodeToDelete.left;
                setPrevChildNode(nodeToDelete, nodeToReplace);
            }
            else
                deleteintheMiddlewitchtwochildren(nodeToDelete);
        }

        private void deleteintheMiddlewitchtwochildren(Node nodetodelete)
        {
            Node leftSmallestLeaf = getLeftSmallestTree(nodetodelete);
            if (leftSmallestLeaf == nodetodelete.left)
            {
                nodetodelete.data = leftSmallestLeaf.data;
                nodetodelete.left = null;
                return;
            }
            Node prvSmallest = GetPreviousNode(leftSmallestLeaf);
            nodetodelete.data = leftSmallestLeaf.data;
            if (leftSmallestLeaf.isLeaf())
            {
                prvSmallest.right = null;
            }
            else
                prvSmallest.right = leftSmallestLeaf.left;

        }

        private Node getLeftSmallestTree(Node startNode)
        {
            Node cur = startNode.left;

            while (cur.right != null)
            {
                cur = cur.right;
            }

            return cur;
        }
        private Node getRightLeaf(Node node)
        {
            while (node != null)
            {
                node = node.right;
            }
            return node;
        }

        public Node GetPreviousNode(Node node)
        {
            while (true)
            {
                Node prev = wurzel;
                Node? cur = wurzel;
                while (true)
                {
                    if (node.data == cur.data)
                        return prev;
                    if (node.data < cur.data)
                    {
                        prev = cur;
                        cur = cur.left;
                    }
                    else if (node.data > cur.data)
                    {
                        prev = cur;
                        cur = cur.right;
                    }
                }
            }
        }
        public Node FindeNode(int data)
        {
            Node? cur = wurzel;
            while (true)
            {
                if (data == cur.data)
                    return cur;
                if (data < cur.data)
                    cur = cur.left;
                else if (data > cur.data)
                    cur = cur.right;
            }
        }
        public override string ToString()
        {
            return getElementsAsString(wurzel);
        }
        string getElementsAsString(Node element)
        {
            if (element == null)
                return "";
            if (element.left == null && element.right == null)
                return element.data.ToString();
            return getElementsAsString(element.left)
            + element.data.ToString()
            + getElementsAsString(element.right);
        }
    }
}