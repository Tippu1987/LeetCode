using System;

namespace MaxAreaOfIsland
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
        //Time Complexity: O(m*n)
        public int MaxAreaOfIsland(int[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;
            int maxArea = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        int localmax = DFS(grid, i, j);
                        maxArea = localmax > maxArea ? localmax : maxArea;
                    }
                }
            }
            return maxArea;
        }

        public int DFS(int[][] grid, int x, int y)
        {
            if (grid == null || grid.Length == 0 || x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length) return 0;
            int max = 0;
            if (grid[x][y] == 1)
            {
                grid[x][y] = 2;
                max = 1 + DFS(grid, x, y - 1) + DFS(grid, x, y + 1) + DFS(grid, x - 1, y) + DFS(grid, x + 1, y);
            }
            return max;
        }
    }
}
