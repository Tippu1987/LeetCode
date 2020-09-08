using System;
using System.Collections.Generic;
using System.Linq;

namespace KClosestPointsToOrigin
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] arr = new int[][] {
                new int[]{ 3, 3 },
                new int[] { 5, -1 },
                new int[]{ -2, 4 }
            };
            Console.WriteLine(s.KClosest(arr, 2));
        }
    }

    public class Solution
    {
        public int[][] KClosest(int[][] points, int K)
        {
            if (points == null || K <= 0) return null;
            int[][] output = new int[K][];
            Dictionary<KeyValuePair<int, int>, double> distanceMap = new Dictionary<KeyValuePair<int, int>, double>();
            for (int i = 0; i <= points.GetUpperBound(0); i++)
            {
                KeyValuePair<int, int> kvp = new KeyValuePair<int, int>(points[i][0], points[i][1]);
                if (!distanceMap.ContainsKey(kvp))
                    distanceMap.Add(new KeyValuePair<int, int>(points[i][0], points[i][1]), Math.Sqrt(points[i][0] * points[i][0] + points[i][1] * points[i][1]));
            }
                
            var result = distanceMap.OrderBy(x => x.Value).Take(K).Select(x => x.Key).ToList();
            int f = 0;
            foreach (var k in result)
                output[f++] = new int[] { k.Key, k.Value };
            return output;
        }
    }

    internal static class ExtensionMethods
    {
        internal static T[][] ToJaggedArray<T>(this T[,] twoDimensionalArray)
        {
            int rowsFirstIndex = twoDimensionalArray.GetLowerBound(0);
            int rowsLastIndex = twoDimensionalArray.GetUpperBound(0);
            int numberOfRows = rowsLastIndex + 1;

            int columnsFirstIndex = twoDimensionalArray.GetLowerBound(1);
            int columnsLastIndex = twoDimensionalArray.GetUpperBound(1);
            int numberOfColumns = columnsLastIndex + 1;

            T[][] jaggedArray = new T[numberOfRows][];
            for (int i = rowsFirstIndex; i <= rowsLastIndex; i++)
            {
                jaggedArray[i] = new T[numberOfColumns];

                for (int j = columnsFirstIndex; j <= columnsLastIndex; j++)
                {
                    jaggedArray[i][j] = twoDimensionalArray[i, j];
                }
            }
            return jaggedArray;
        }
    }
}
