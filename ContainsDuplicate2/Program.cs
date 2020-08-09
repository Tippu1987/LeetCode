using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ContainsDuplicate2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 1, 2, 3 };
            int k = 2;
            Console.WriteLine(ContainsNearbyDuplicate(nums, k));
        }

        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0) return false;
            Dictionary<int, List<int>> indices = new Dictionary<int, List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (indices.ContainsKey(nums[i]))
                {
                    if (indices[nums[i]].Any(x => Math.Abs(x - i) <= k))
                        return true;
                    else
                        indices[nums[i]].Add(i);
                }
                else
                    indices.Add(nums[i], new List<int> { i });
            }
            return false;
        }
    }
}
