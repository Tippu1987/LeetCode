using System;
using System.Collections.Generic;
using System.Globalization;

namespace _2ArrayIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 4, 5, 9 };
            int[] nums2 = new int[] { 4, 4, 8, 9, 9 };
            IntersectSortedArrays(nums1, nums2);
        }


        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> nums = new Dictionary<int, int>();
            List<int> output = new List<int>();
            for (int i = 0; i < nums1.Length; ++i)
                if (nums.ContainsKey(nums1[i]))
                    nums[nums1[i]] += 1;
                else
                    nums.Add(nums1[i], 1);
            for (int i = 0; i < nums2.Length; ++i)
            {
                if (nums.ContainsKey(nums2[i]) && nums[nums2[i]] > 0)
                {
                    output.Add(nums2[i]);
                    nums[nums2[i]] -= 1;
                }
            }
            return output.ToArray();
        }

        /// <summary>
        /// If nums1 & nums2 are sorted
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static int[] IntersectSortedArrays(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<int> output = new List<int>();
            int i = 0, j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    output.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if (nums1[i] < nums2[j])
                    i++;
                else if (nums1[i] > nums2[j])
                    j++;
            }
            return output.ToArray();
        }
    }
}
