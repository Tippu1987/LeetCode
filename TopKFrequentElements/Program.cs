using System;
using System.Collections.Generic;
using System.Linq;

namespace TopKFrequentElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
            Console.WriteLine(TopKFrequent(nums,2));
        }

        public static int[] TopKFrequent(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k <= 0) return null;
            Dictionary<int, int> numCount = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numCount.ContainsKey(nums[i]))
                    numCount[nums[i]] += 1;
                else
                    numCount[nums[i]] = 1;
            }
            var topKelements = numCount.OrderByDescending(x => x.Value).Take(k);
            return topKelements.Select(x => x.Key).ToArray();
        }
    }
}
