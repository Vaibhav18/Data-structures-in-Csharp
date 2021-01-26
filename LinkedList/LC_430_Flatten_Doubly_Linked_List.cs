using DataStructures.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class LC_430_Flatten_Doubly_Linked_List
    {
        /// <summary>
        /// Solution for LeetCode - 430 Flatten a Multilevel Doubly Linked List
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public Node Flatten(Node head)
        {
            Queue<Node> q = new Queue<Node>();
            Node currentNode = head;
            Stack<Node> s = new Stack<Node>();

            while (currentNode != null || s.Count > 0)
            {
                if (currentNode == null && s.Count > 0)
                {
                    currentNode = s.Pop();
                }

                if (currentNode != null)
                {
                    q.Enqueue(currentNode);
                }

                if (currentNode.child != null)
                {
                    if (currentNode.next != null) s.Push(currentNode.next);
                    currentNode = currentNode.child;
                }
                else
                {
                    currentNode = currentNode.next;
                }
            }

            Node prevNode = null;
            Node result = null;
            while (q.Count > 0)
            {
                Node newNode = q.Dequeue();
                newNode.child = null;
                if (result == null) result = newNode;
                newNode.prev = prevNode;
                if (prevNode != null) prevNode.next = newNode;
                prevNode = newNode;
            }

            return result;
        }
    }
}
