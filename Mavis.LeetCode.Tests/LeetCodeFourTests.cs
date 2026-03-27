using Mavis.LeetCode.Solutions;
using Shouldly;

namespace Mavis.LeetCode.Tests
{
    public class LeetCodeFourTests
    {
        [Fact]
		public void TestOne()
		{
			var leetCodeFour = new LeetCodeFour();
			var result = leetCodeFour.StrStr("foobarfoo", "bar");
			result.ShouldBe(3);
		}

		[Fact]
		public void TestTwo()
		{
			var leetCodeFour = new LeetCodeFour();
			var result = leetCodeFour.StrStr("barfoo", "bar");
			result.ShouldBe(0);
		}

		[Fact]
		public void TestThree()
		{
			var leetCodeFour = new LeetCodeFour();
			var result = leetCodeFour.StrStr("barfoo", "bara");
			result.ShouldBe(-1);
		}

		[Fact]
		public void TestFour()
		{
			var leetCodeFour = new LeetCodeFour();
			var result = leetCodeFour.StrStr("barfofoo", "foo");
			result.ShouldBe(5);
		}

		[Fact]
		public void TestFive()
		{
			var leetCodeFour = new LeetCodeFour();
			var result = leetCodeFour.StrStr("leetcode", "leeto");
			result.ShouldBe(-1);
		}

		[Fact]
		public void TestSix()
		{
			var leetCodeFour = new LeetCodeFour();
			var result = leetCodeFour.StrStr("mississippi", "issip");
			result.ShouldBe(4);
		}
	}
}
