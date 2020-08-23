using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace RottingOranges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] rottingoranges = new int[][]
            {
                new int[] { 2, 1,1,1,1,1, },
                new int[] { 1, 1,1,1,1,1, },
                new int[] { 1, 1,1,1,1,1, },
                new int[] { 1, 1,1,1,1,1, },
                new int[] { 1, 1,1,1,1,1, }
            };
            Solution s = new Solution();
            Console.WriteLine(s.OrangesRotting(rottingoranges));
        }
        public class Solution
        {
            //O(m*n) Algorithm
            //
            public int OrangesRotting(int[][] grid)
            {
                if (grid == null || grid.Length == 0) return -1;
                int freshOrangeCount = 0, minutesCounter = 0;
                Queue<OrangeNode> bfsQ = new Queue<OrangeNode>();
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[0].Length; j++)
                    {
                        if (grid[i][j] == 2)
                            bfsQ.Enqueue(new OrangeNode(i, j, 0));
                        else if (grid[i][j] == 1)
                            freshOrangeCount++;
                    }
                }
                if (freshOrangeCount == 0) return 0;
                List<OrangeNode> tempList = new List<OrangeNode>();
                while (bfsQ.Count > 0)
                {
                    while (bfsQ.Count > 0)
                    {
                        var currentOrange = bfsQ.Dequeue();
                        minutesCounter = currentOrange.currentTime;
                        if (currentOrange.x - 1 >= 0 && grid[currentOrange.x - 1][currentOrange.y] == 1)
                        {
                            tempList.Add(new OrangeNode(currentOrange.x - 1, currentOrange.y, currentOrange.currentTime +1));
                            grid[currentOrange.x - 1][currentOrange.y] = 2;
                            freshOrangeCount--;
                        }
                        if (currentOrange.x + 1 < grid.Length && grid[currentOrange.x + 1][currentOrange.y] == 1)
                        {
                            tempList.Add(new OrangeNode(currentOrange.x + 1, currentOrange.y, currentOrange.currentTime + 1));
                            grid[currentOrange.x + 1][currentOrange.y] = 2;
                            freshOrangeCount--;
                        }
                        if (currentOrange.y - 1 >= 0 && grid[currentOrange.x][currentOrange.y - 1] == 1)
                        {
                            tempList.Add(new OrangeNode(currentOrange.x, currentOrange.y - 1, currentOrange.currentTime + 1));
                            grid[currentOrange.x][currentOrange.y - 1] = 2;
                            freshOrangeCount--;
                        }
                        if (currentOrange.y + 1 < grid[0].Length && grid[currentOrange.x][currentOrange.y + 1] == 1)
                        {
                            tempList.Add(new OrangeNode(currentOrange.x, currentOrange.y + 1, currentOrange.currentTime + 1));
                            grid[currentOrange.x][currentOrange.y + 1] = 2;
                            freshOrangeCount--;
                        }
                    }
                    tempList.ForEach(x => bfsQ.Enqueue(x));
                    tempList.Clear();
                }
                return freshOrangeCount == 0 ? minutesCounter : -1;
            }
        }

        class OrangeNode
        {
            public int x, y;
            public int currentTime;
            public OrangeNode(int x, int y, int time)
            {
                this.x = x;
                this.y = y;
                currentTime = time;
            }
        }
    }

}
