using System;
using System.Collections.Generic;
using System.Text;

namespace Mavis.LeetCode.Solutions
{
	/// <summary>
	/// https://leetcode.com/problems/remove-element/description/
    ///Ove thought the solution, could be much simpler.
	/// </summary>
	public class LeetCodeSix
    {
        public int RemoveElement(int[] nums, int val)
        {
            if(nums.Length == 0){ return 0; }
            
            if(nums.Length == 1)
            {
                return nums[0] == val ? 0 : 1;
            }

            int upperRangeIndex = nums.Length - 1;
            int count = 0;

            for(int i=0; i < nums.Length; i++)
            {
				if (upperRangeIndex == i)
				{
                    count = nums[i] != val ? count + 1 : count;
                    return count;
				}

				if (nums[i] == val)
                {
					while (nums[upperRangeIndex] == val)
                    {
                        upperRangeIndex--;
                        
						if (upperRangeIndex == i)
						{
							return count;
						}
					}
					count++;
					nums[i] = nums[upperRangeIndex];
                    nums[upperRangeIndex] = val;
                }
                else
                {
                    count++;
                }
            }

            return 0;
        }
    }
}
