using DataStructures.Util;

namespace DataStructures.LinkedList
{
    class LC_1669_Merge_In_Between_Linked_Lists
    {
        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            ListNode first = list1;
            int i = 0;

            while (i != a - 1)
            {
                first = first.next;
                i++;
            }

            ListNode second = first;
            while (i != b + 1)
            {
                second = second.next;
                i++;
            }

            ListNode lastNode = list2;
            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }

            first.next = list2;
            lastNode.next = second;
            return list1;

        }
    }
}
