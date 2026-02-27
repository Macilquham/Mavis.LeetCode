namespace Mavis.LeetCode.Solutions
{
    public class LeetCodeOne
    {
		public void MergeTwoLists(ListNode list1)
		{
            ListNode newCurrent = new();
            ListNode newList = new(list1.val);

            if(list1.next != null)
            {
                newList.next = newCurrent;
                newList.next.val = list1.next.val;
                list1 = list1.next.next;
            }

            while(list1 != null)
            {
                newCurrent.next = new ListNode(list1.val);
                list1 = list1.next;
                newCurrent = newCurrent.next;
            }

		}
	}

	
    //Definition for singly-linked list.
	public class ListNode {
      public int val;
      public ListNode? next;
      public ListNode(int val=0, ListNode? next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
}
