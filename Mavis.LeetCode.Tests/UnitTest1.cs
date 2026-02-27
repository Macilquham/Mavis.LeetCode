using Mavis.LeetCode.Solutions;

namespace Mavis.LeetCode.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void TestOne()
		{
			LeetCodeOne leetCodeOne = new();
			leetCodeOne.MergeTwoLists(new ListNode(1, new ListNode(2, new ListNode(4, new ListNode(14)))));
		}
	}
}
