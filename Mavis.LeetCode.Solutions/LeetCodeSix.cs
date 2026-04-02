using System;
using System.Collections.Generic;
using System.Text;

namespace Mavis.LeetCode.Solutions
{
    public class LeetCodeSix
    {
        public int RemoveElement(int[] nums, int val)
        {

            if(nums.Length == 0){ return 0; }
            
            if(nums.Length == 1)
            {
                return nums[0] == val ? 0 : 1;
            }

            int numberOfDuplicateFound = 0;

            for (int i = 0; i <= nums.Length / 2 + 1; i++)
            {
                if (i == nums.Length)
                {
                    return nums.Length - numberOfDuplicateFound;
                }

                if (nums[i] == val)
                {
                    while (nums[nums.Length - 1 - numberOfDuplicateFound] == val)
                    {
                        numberOfDuplicateFound++;

                        if (numberOfDuplicateFound == nums.Length)
                        {
                            return 0;
                        }
                    }

                    if (numberOfDuplicateFound + i == nums.Length)
                    {
                        return nums.Length - numberOfDuplicateFound;
                    }

                    nums[i] = nums[nums.Length - 1 - numberOfDuplicateFound];
                    nums[nums.Length - 1 - numberOfDuplicateFound] = val;
                }
            }

            for (int j = nums.Length / 2; j < nums.Length; j++)
            {
                if (nums[j] == val)
                {
                    return j;
                }
            }

            return nums.Length;
        }
    }
}
