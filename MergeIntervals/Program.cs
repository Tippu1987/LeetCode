using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] inp = new int[][]
            {
               new int[]{0, 0 },
               new int[]{1, 2 },
               new int[]{5, 5 },
               new int[]{2, 4 },
               new int[]{3, 3 },
               new int[]{5, 6 },
               new int[]{5, 6 },
               new int[]{4, 6 },
               new int[]{0, 0 },
               new int[]{1, 2 },
               new int[]{0, 2 },
               new int[]{4, 5 }
            };
            Console.WriteLine(s.Merge(inp));
        }
    }
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0) return new int[][] { };
            var resHS = new LinkedList<int[]>();
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
            for (int i = 0; i < intervals.Length; i++)
            {
                if (resHS.Count == 0 || resHS.Last.Value[1] < intervals[i][0])
                    resHS.AddLast(intervals[i]);
                else
                    resHS.Last.Value[1] = Math.Max(resHS.Last.Value[1], intervals[i][1]);
            }
            return resHS.ToArray();
        }
    }
}
