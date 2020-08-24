using System;

namespace NumberOfIslands
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        int numOfIslands = 0;
        //Time Complexity O(m*n)
        //Space: 4* num of 1's in the grid
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        BFS(grid, i, j);
                        numOfIslands++;
                    }
                }
            }
            return numOfIslands;
        }

        public void BFS(char[][] grid, int i, int j)
        {
            if (grid == null || grid.Length == 0 || i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length) return;
            if (grid[i][j] == '1')
            {
                grid[i][j] = '2';
                BFS(grid, i - 1, j);
                BFS(grid, i + 1, j);
                BFS(grid, i, j + 1);
                BFS(grid, i, j - 1);
            }
        }
    }

}
