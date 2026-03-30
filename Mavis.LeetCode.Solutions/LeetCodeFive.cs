using System;
using System.Collections.Generic;
using System.Text;

namespace Mavis.LeetCode.Solutions
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
    /// </summary>
    public class LeetCodeFive
    {
        public int RemoveDuplicates(int[] nums)
        {
            var nextIndexToAddEntry = 1;
            var currentValue = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != currentValue)
                {
                    nums[nextIndexToAddEntry] = nums[i];
                    nextIndexToAddEntry++;
                    currentValue = nums[i];
                }
            }

            return nextIndexToAddEntry;
        }
    }
}
