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

            var isNine = true;
            var actualCount = digits.Length;
            
            for(; actualCount > 0; actualCount--)
            {
                if (isNine)
                {
                    isNine = digits[actualCount - 1] == 9;

                    if (!isNine)
                    {
                        break;
                    }
                }
            }

            if(actualCount == 0)
            {
                var newDigits = new int[digits.Length + 1];
                newDigits[0] = 1;
                return newDigits;
            }

            else
            {
                var index = actualCount - 1;
                for (; actualCount <= digits.Length; actualCount++)
                {
                    if(digits[index] < 9)
                    {
						digits[index] = digits[index] + 1;
					}
                    else
                    {
                        digits[index] = 0;
					}
                    index++;

				}

                return digits;
            }
        }
    }

	//Wont work because number exceeds biggest int value
	public class LeetCodeTwoAttemptOne
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
