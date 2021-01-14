using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class LinkedList
    {
        public LinkedListNode head = null;
        public void Add(int data)
        {
            if(head == null)
            {
                this.head = new LinkedListNode(data);
                return;
            }
            LinkedListNode current = head;
            while(current.next != null)
            {
                current = current.next;
            }
            current.next = new LinkedListNode(data);
        }

        public void AddAtIndex(int data, int index)
        {
            if (head == null && index > 0) throw new IndexOutOfRangeException();

            int currentIndex = 0;
            LinkedListNode currentNode = head;
            while(currentNode.next != null)
            {
                if(currentIndex + 1 == index)
                {
                    break;
                }
                currentNode = currentNode.next;
            }

            LinkedListNode nextNode = currentNode.next;
            currentNode.next = new LinkedListNode(data);
            currentNode.next.next = nextNode;
        }
    }

    class LinkedListNode
    {
        public LinkedListNode next = null;
        public int data;

        public LinkedListNode(int data)
        {
            this.data = data;
        }
    }
}
