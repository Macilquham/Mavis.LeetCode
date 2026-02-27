using Mavis.LeetCode.Solutions;

namespace Mavis.LeetCode.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void ListTwoNull()
		{
			LeetCodeOne leetCodeOne = new();
			leetCodeOne.MergeTwoLists(new ListNode(1, new ListNode(2, new ListNode(4, new ListNode(14)))), null!);
		}

		[Fact]
		public void ListOneNull()
		{
			LeetCodeOne leetCodeOne = new();
			leetCodeOne.MergeTwoLists(null!, new ListNode(1, new ListNode(2, new ListNode(4, new ListNode(14)))));
		}

		[Fact]
		public void ListOneLonger()
		{
			LeetCodeOne leetCodeOne = new();
			var list1 = new ListNode(1, new ListNode(2, new ListNode(4, new ListNode(14))));
			var list2 = new ListNode(3, new ListNode(11));
			leetCodeOne.MergeTwoLists(list1, list2);
		}

		[Fact]
		public void ListTwoLonger()
		{
			LeetCodeOne leetCodeOne = new();
			leetCodeOne.MergeTwoLists(null!, new ListNode(1, new ListNode(2, new ListNode(4, new ListNode(14)))));
		}

		[Fact]
		public void ListsSameSize()
		{
			LeetCodeOne leetCodeOne = new();
			leetCodeOne.MergeTwoLists(null!, new ListNode(1, new ListNode(2, new ListNode(4, new ListNode(14)))));
		}
	}
}
