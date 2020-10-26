using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace KthSamllestInLexicoGraphicalOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.FindKthNumber(int.MaxValue, 1922239));
        }
    }

    public class Solution 
    {
        public int FindKthNumber(int n, int k)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= int.MaxValue; i++)
                numbers.Add(i);
            numbers.Sort(new NumberStringSorter());
            return numbers[k - 1];
        }
    }

    public class NumberStringSorter : IComparer<int>
    {
        public int Compare([AllowNull] int x, [AllowNull] int y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }

}
