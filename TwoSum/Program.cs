using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1,1};
            Console.WriteLine(string.Join(',', FindDisappearedNumbers(array)));
        }

        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> res = new List<int>();
            if (nums == null || nums.Length == 0) return nums;
            HashSet<int> distincts = new HashSet<int>(nums);
            for(int i=1;i<=nums.Length;i++)
            {
                if (!distincts.Contains(i))
                    res.Add(i);
            }
            return res;
        }
        public static void Swap(int[] arr, int i, int j)
        {
            //arr[i]=10, arr[j]=20
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }
    }
}
