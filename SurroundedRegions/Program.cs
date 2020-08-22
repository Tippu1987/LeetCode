using System;

namespace SurroundedRegions
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[][]
            {
               new char[]  { 'X','X','X','X' },
               new char[]  {'X' ,'O','O','X'},
                new char[] {'X','X','O','X'},
                new char[] {'X' ,'O','X','X'}
            };
            Solution s = new Solution();
            s.Solve(board);
        }
    }
    public class Solution
    {
        int rows, cols;
        public void Solve(char[][] board)
        {
            if (board == null || board.Length == 0) return;
            this.rows = board.GetUpperBound(0);
            this.cols = board[0].Length;
            for (int i = 0; i < cols; i++)
            {
                if (board[0][i] == 'O')
                    DFS(board, 0, i);
                if (board[this.rows][i] == 'O')
                    DFS(board, this.rows, i);
            }
            for (int i = 0; i <= rows; i++)
            {
                if (board[i][0] == 'O')
                    DFS(board, i, 0);
                if (board[i][this.cols - 1] == 'O')
                    DFS(board, i, this.cols - 1);
            }

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i][j] == 'O')
                        board[i][j] = 'X';
                    if (board[i][j] == 'E')
                        board[i][j] = 'O';
                }
            }
        }
        public void DFS(char[][] board, int row, int col)
        {
            if (board == null || board.Length == 0 || row < 0 || row > this.rows || col < 0 || col >= this.cols) return;
            if (board[row][col] == 'O')
            {
                board[row][col] = 'E';
                DFS(board, row - 1, col);
                DFS(board, row + 1, col);
                DFS(board, row, col + 1);
                DFS(board, row, col - 1);
            }
        }
    }
}
