using Mavis.LeetCode.Solutions;
using Shouldly;

namespace Mavis.LeetCode.Tests
{
    public class LeetCodeFiveTests
    {
        [Fact]
		public void TestOne()
		{
			var leetCodeFour = new LeetCodeFive();
            int[] input = [1, 1, 2];
            int result = leetCodeFour.RemoveDuplicates(input);
			result.ShouldBe(2);
		}

		[Fact]
		public void TestTwo()
		{
			var leetCodeFour = new LeetCodeFive();
			int[] input = [0,0,1,1,1,2,2,3,3,4];
			var result = leetCodeFour.RemoveDuplicates(input);
			result.ShouldBe(5);
		}

		[Fact]
		public void TestThree() {
			var leetCodesFour = new LeetCodeFive();
			int[] input = [0,0,0,0,3];
			var result = leetCodesFour.RemoveDuplicates(input);
			result.ShouldBe(2);
		}
	}
}
