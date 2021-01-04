using System;

namespace FruitsIntoBaskets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int TotalFruit(int[] tree)
        {
            if (tree == null || tree.Length == 0) return 0;
            int windowStart = 0, count = 0, maxcnt = 0;
            for (int windowEnd = 0; windowEnd < tree.Length; windowEnd++)
            {
                if (tree[windowEnd] != tree[windowEnd + 1])
                {
                    if (count < 2)
                        continue;
                    else
                    {
                        maxcnt = Math.Max(maxcnt, windowEnd - windowStart + 1);
                        count = 0;
                    }
                }
            }
        }
    }
}
