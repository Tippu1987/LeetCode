using System;

namespace ProductOfNumsExceptSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4 };
            ProductExceptSelfLinearTimeAndConstantSpace(nums);
        }

        /// <summary>
        /// Initial Algo that Pavan Came up with time outed on Leetcode huge input
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] ProductExceptSelf(int[] nums)
        {
            if (nums == null || nums.Length == 0) return nums;
            int[] output = new int[nums.Length];
            int lp=1, rp=1;
            for (int i = 0; i < nums.Length; i++)
            {
                int left = i - 1;
                int right = i + 1;
                while(left>=0 || right< nums.Length)
                {
                    if (!(left < 0)) lp *= nums[left--];
                    if (!(right >= nums.Length)) rp *= nums[right++];
                }
                output[i] = lp * rp;
                lp = rp = 1;
            }
            return output;
        }

        /// <summary>
        /// Linear Algo with O(N) Space Approach 1 in LC
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] ProductExceptSelfLinearTimeAndSpace(int[] nums)
        {
            if (nums == null || nums.Length == 0) return nums;
            int[] output = new int[nums.Length];
            int[] leftArray = new int[nums.Length];
            int[] rightArray = new int[nums.Length];
            leftArray[0] = rightArray[nums.Length - 1] = 1;
            for (int i = 1; i < nums.Length; i++)
                leftArray[i] = leftArray[i - 1] * nums[i - 1];
            for (int i = nums.Length - 2; i >= 0; i--)
                rightArray[i] = rightArray[i + 1] * nums[i + 1];
            for (int i = 0; i < nums.Length; i++)
                output[i] = leftArray[i] * rightArray[i];
            return output;
        }

        /// <summary>
        /// Linear Algo with O(1) Space Approach 1 in LC
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] ProductExceptSelfLinearTimeAndConstantSpace(int[] nums)
        {
            if (nums == null || nums.Length == 0) return nums;
            int[] output = new int[nums.Length];
            int intermediateProd = 1;
            output[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                output[i] = intermediateProd * nums[i - 1];
                intermediateProd = output[i];
            }
            intermediateProd = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                output[i] = output[i] * intermediateProd;
                intermediateProd *= nums[i];
            }
            return output;
        }
    }
}
