namespace Mavis.LeetCode.Solutions
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists/description/
    /// </summary>
    public class LeetCodeOne
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }

            ListNode currentNode = new();
            ListNode mergedListHead = new();
            mergedListHead.next = currentNode;

            while (list1 != null)
            {
                if (list2 == null || list1.val <= list2.val)
                {
                    currentNode.val = list1.val;
                    list1 = list1.next!;
                }
                else
                {
                    currentNode.val = list2.val;
                    list2 = list2.next!;
                }

                if (list1 != null || list2 != null)
                {
                    currentNode.next = new ListNode();
                    currentNode = currentNode.next;
                }
            }

            while (list2 != null)
            {
                currentNode.val = list2.val;
                list2 = list2.next!;
                if (list2 != null)
                {
                    currentNode.next = new ListNode();
                    currentNode = currentNode.next;
                }

            }
            
            return mergedListHead.next;
        }
    }


    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
