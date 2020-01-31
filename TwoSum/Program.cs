using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 2,7,7,11 };
            int trg = 13;
            int[] res = TwoSum(num, trg);
            Console.WriteLine($"Locations={res[0]},{res[1]}");
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> tempMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (tempMap.ContainsKey(target - nums[i]))
                {
                    return new int[] { tempMap[target - nums[i]], i };
                }
                else
                {
                    if (!tempMap.ContainsKey(nums[i]))
                        tempMap.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}
