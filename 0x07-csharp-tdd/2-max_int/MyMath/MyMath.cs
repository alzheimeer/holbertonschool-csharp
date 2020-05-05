using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>method that returns the max integer in a list of integers</summary>
    public class Operations
    {
        /// <summary>Max integer</summary>
        /// <param name="nums">list</param>
        /// <returns>max integer in list, If nums is empty, return 0</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count <= 0)
                return 0;
            int max = nums[0];
            foreach(int i in nums)
                if (i > max)
                    max = i;
            return max;
        }
    }
}
