using System;
using System.Collections.Generic;
using System.Text;

namespace Mavis.LeetCode.Solutions
{
    public class LeetCodeSix
    {
        public int RemoveElement(int[] nums, int val)
        {
            bool hasBeenDecremented = false;
            if(nums.Length == 0){ return 0; }
            
            if(nums.Length == 1)
            {
                return nums[0] == val ? 0 : 1;
            }

            int upperRangeIndex = nums.Length - 1;

            for(int i=0; i < nums.Length; i++)
            {
				if (upperRangeIndex == i)
				{
					return hasBeenDecremented ? upperRangeIndex : nums.Length;
				}

				if (nums[i] == val)
                {
					hasBeenDecremented = true;
					while (nums[upperRangeIndex] == val)
                    {
                        upperRangeIndex--;
                        
						if (upperRangeIndex == i)
						{
							return upperRangeIndex;
						}
					}

                    nums[i] = nums[upperRangeIndex];
                    nums[upperRangeIndex] = val;
                }
            }

            return 0;
        }
    }
}
