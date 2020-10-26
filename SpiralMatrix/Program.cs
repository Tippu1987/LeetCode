using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] matrix = new int[][]
            {
                new int[]{ 1, 2, 3, 4},
                new int[]{5, 6, 7, 8},
                new int[]{9, 10, 11, 12} 
            };
            Console.WriteLine($"{string.Join(',',s.SpiralOrder(matrix))}");
        }
    }
    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> result = new List<int>();
            if (matrix == null || matrix.Length == 0) return result;
            int topRow = 0, leftCol = 0;
            int bottomRow = matrix.Length - 1, rightCol = matrix[0].Length - 1;
            int totalelements = matrix.Length * matrix[0].Length;

            while (result.Count < totalelements)
            {
                for (int i = leftCol; i <= rightCol && result.Count < totalelements; i++)
                    result.Add(matrix[topRow][i]);
                topRow++;
                for (int i = topRow; i <= bottomRow && result.Count < totalelements; i++)
                    result.Add(matrix[i][rightCol]);
                rightCol--;
                for (int i = rightCol; i >= leftCol && result.Count < totalelements; i--)
                    result.Add(matrix[bottomRow][i]);
                bottomRow--;
                for (int i = bottomRow; i >= topRow && result.Count < totalelements; i--)
                    result.Add(matrix[i][leftCol]);
                leftCol++;
            }
            return result;
        }
    }
}
