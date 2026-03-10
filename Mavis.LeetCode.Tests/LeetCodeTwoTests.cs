using Mavis.LeetCode.Solutions;
using Shouldly;

namespace Mavis.LeetCode.Tests
{
    public class LeetCodeTwoTests
    {
        [Fact]
		public void TestOne()
		{
			LeetCodeTwo leetCodeTwo = new();
			leetCodeTwo.PlusOne([1,2,3]).ShouldBe([1,2,4]);
		}

		[Fact]
		public void TestTwo()
		{
			LeetCodeTwo leetCodeTwo = new();
			leetCodeTwo.PlusOne([1,2,9]).ShouldBe([1,3,0]);
		}

		[Fact]
		public void TestThree()
		{
			LeetCodeTwo leetCodeTwo = new();
			leetCodeTwo.PlusOne([1,2,3,4,5,6,7,8,9,9,9,9,9]).ShouldBe([1,2,3,4,5,6,7,9,0,0,0,0,0]);
		}

		[Fact]
		public void TestFour()
		{
			LeetCodeTwo leetCodeTwo = new();
			leetCodeTwo.PlusOne([9, 9, 9, 9]).ShouldBe([1, 0, 0, 0, 0]);
		}
	}
}
