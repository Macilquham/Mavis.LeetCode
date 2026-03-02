using Mavis.LeetCode.Solutions;
using Shouldly;

namespace Mavis.LeetCode.Tests
{
	public class LeetCodeOneTests
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
		public void ListsBothHaveOneItem()
		{
			LeetCodeOne leetCodeOne = new();
			var list1 = new ListNode(2);
			var list2 = new ListNode(1);
			var mergedList = leetCodeOne.MergeTwoLists(list1, list2);
			mergedList.val.ShouldBe(1);
			mergedList.next.val.ShouldBe(2);
            mergedList.next.next.ShouldBeNull();
		}

		[Fact]
		public void ListTwoLonger()
		{
			LeetCodeOne leetCodeOne = new();
			var mergedList = leetCodeOne.MergeTwoLists(new ListNode(1), new ListNode(1, new ListNode(3, new ListNode(4))));
			mergedList.val.ShouldBe(1);
			mergedList.next.val.ShouldBe(1);
			mergedList.next.next.val.ShouldBe(3);
			mergedList.next.next.next.val.ShouldBe(4);
			mergedList.next.next.next.next.ShouldBeNull();
		}


		[Fact]
		public void ListSameSize()
		{
			LeetCodeOne leetCodeOne = new();
			var mergedList = leetCodeOne.MergeTwoLists(new ListNode(1, new ListNode(2, new ListNode(4))), new ListNode(1, new ListNode(3, new ListNode(4))));
			mergedList.val.ShouldBe(1);
			mergedList.next.val.ShouldBe(1);
			mergedList.next.next.val.ShouldBe(2);
			mergedList.next.next.next.val.ShouldBe(3);
			mergedList.next.next.next.next.val.ShouldBe(4);
			mergedList.next.next.next.next.next.val.ShouldBe(4);
			mergedList.next.next.next.next.next.next.ShouldBeNull();
		}

		
	}
}
