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

            int lowerRangeValIndex = 0;
            int upperRangeValIndex = nums.Length - 1;
            bool lowerRangeNeedsSwapping = false;
            bool upperRangeNeedsSwapping = false;

            for(int i=0; i < nums.Length / 2 + 1; i++)
            {
                if (nums[i] == val)
                {
                    lowerRangeValIndex = i;
                    lowerRangeNeedsSwapping = true;
				}
                if (nums[nums.Length - (i + 1)] != val)
                {
                    upperRangeNeedsSwapping = true;
				}
                if(nums[nums.Length - (i + 1)] == val)
                {
                    if (upperRangeNeedsSwapping)
                    {
                        nums[nums.Length - (i + 1)] = nums[upperRangeValIndex];
                        nums[upperRangeValIndex] = val;
                        upperRangeNeedsSwapping = false;
					}

					upperRangeValIndex--;
				}

                if (nums[nums.Length - (i + 1)] != val && lowerRangeNeedsSwapping && lowerRangeValIndex < upperRangeValIndex)
                {
                    nums[lowerRangeValIndex] = nums[upperRangeValIndex];
					nums[upperRangeValIndex] = val;
                    lowerRangeNeedsSwapping = false;
                    upperRangeValIndex--;
				}
            }

            return 0;
        }
    }
}
