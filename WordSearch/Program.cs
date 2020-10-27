using System;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            char[][] board = new[]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };

            Console.WriteLine(s.Exist(board, "ABCB"));
        }
    }

    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            if (board == null || board.Length == 0 || string.IsNullOrEmpty(word)) return false;
            bool wordExists = false;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == word[0] && !wordExists)
                    {
                        wordExists = DFS(board, i, j, word);
                    }
                }
            }
            return wordExists;
        }
        private bool DFS(char[][] board, int i, int j, string word)
        {
            if (string.IsNullOrEmpty(word)) return true;
            if (board == null || i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[0]) return false;
            char temp = board[i][j];
            board[i][j] = ' ';
            var found = DFS(board, i, j + 1, word.Substring(1)) ||
             DFS(board, i, j - 1, word.Substring(1)) ||
             DFS(board, i + 1, j, word.Substring(1)) ||
             DFS(board, i - 1, j, word.Substring(1));
            board[i][j] = temp;
            return found;
        }
    }
}
