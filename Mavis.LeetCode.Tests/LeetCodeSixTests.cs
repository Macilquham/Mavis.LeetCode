using Mavis.LeetCode.Solutions;
using Shouldly;

namespace Mavis.LeetCode.Tests
{
    public class LeetCodeSixTests
    {
        [Fact]
		public void TestOne()
		{
			var leetCodeSix = new LeetCodeSix();
            int[] input = [3,2,2,3];
            int result = leetCodeSix.RemoveElement(input, 3);
			input[2].ShouldBe(3);
			input[3].ShouldBe(3);
			//result.ShouldBe(2);
		}

		[Fact]
		public void TestTwo()
		{
			var leetCodeSix = new LeetCodeSix();
			int[] input = [0,1,2,2,3,0,4,2];
			int result = leetCodeSix.RemoveElement(input, 2);
			input[7].ShouldBe(2);
			input[6].ShouldBe(2);
			input[5].ShouldBe(2);
			//result.ShouldBe(5);
		}

		[Fact]
		public void TestThree()
		{
			var leetCodeSix = new LeetCodeSix();
			int[] input = [0,1,2,2,2];
			int result = leetCodeSix.RemoveElement(input, 2);
			input[2].ShouldBe(2);
			input[3].ShouldBe(2);
			input[4].ShouldBe(2);
			//result.ShouldBe(2);
		}

		[Fact]
		public void TestFour()
		{
			var leetCodeSix = new LeetCodeSix();
			int[] input = [2,2,2,2,1];
			int result = leetCodeSix.RemoveElement(input, 2);
			input[0].ShouldBe(1);
			input[1].ShouldBe(2);
			//result.ShouldBe(1);
		}


		[Fact]
		public void TestFive()
		{
			var leetCodeSix = new LeetCodeSix();
			int[] input = [2,2,2,2,1,2,2,2];
			int result = leetCodeSix.RemoveElement(input, 2);
			input[0].ShouldBe(1);
			input[1].ShouldBe(2);
			//result.ShouldBe(1);

		}

		[Fact]
		public void TestSix()
		{
			var leetCodeSix = new LeetCodeSix();
			int[] input = [3,3];
			int result = leetCodeSix.RemoveElement(input, 3);
			//result.ShouldBe(0);
		}

		[Fact]
		public void TestSeven()
		{
			var leetCodeSix = new LeetCodeSix();
			int[] input = [1,2,3,4];
			int result = leetCodeSix.RemoveElement(input, 3);
			input[3].ShouldBe(3);
			//result.ShouldBe(3);
			
		}

		[Fact]
		public void TestEight()
		{
			var leetCodeSix = new LeetCodeSix();
			int[] input = [4,2,0,2,2,1,4,4,1,4,3,2];
			int result = leetCodeSix.RemoveElement(input, 4);
			input[11].ShouldBe(4);
			input[10].ShouldBe(4);
			input[9].ShouldBe(4);
			input[8].ShouldBe(4);
			//result.ShouldBe(8);
		}

		[Fact]
		public void TestNine()
		{
			var leetCodeSix = new LeetCodeSix();
			int[] input = [3,3];
			int result = leetCodeSix.RemoveElement(input, 5);
			//result.ShouldBe(2);
		}
	}

	public record Foo(string Name, string Address);
}
