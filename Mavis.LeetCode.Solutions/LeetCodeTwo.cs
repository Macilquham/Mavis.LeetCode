namespace Mavis.LeetCode.Solutions
{
    public class LeetCodeTwo
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits[digits.Length - 1] < 9)
            {
                digits[digits.Length - 1] = digits[digits.Length - 1] + 1;

                return digits;
            }

            long newNum = 0;
            foreach (var num in digits)
            {
                newNum = (long)(newNum * 10 + num);
            }

            newNum++;
            return ToIntArray(newNum);
        }

        private int[] ToIntArray(long newNum)
        {
            List<int> digits = [];
            for (; newNum != 0; newNum /= 10)
            {

                digits.Add((int)(newNum % 10));
            }

            digits.Reverse();
            return digits.ToArray();
        }
    }


}
