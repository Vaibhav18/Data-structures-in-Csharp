using DataStructures.Util;

namespace DataStructures.LinkedList
{
    class LC_1721_Swapping_Nodes_in_a_Linked_List
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode dummy2 = dummy;
            ListNode firstNode = null;
            int i = 0;
            while (dummy2 != null)
            {
                if (i < k)
                {
                    dummy2 = dummy2.next;
                    firstNode = dummy2;
                    i++;
                }
                else
                {
                    dummy = dummy.next;
                    dummy2 = dummy2.next;
                }
            }

            int temp = firstNode.val;
            firstNode.val = dummy.val;
            dummy.val = temp;
            return head;
        }
    }
}
