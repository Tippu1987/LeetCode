using System;
using System.Collections.Generic;

namespace ValidSudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board =
            {
                new char[]{'.','.','.','.','5','.','.','1','.'},
                new char[]{'.','4','.','3','.','.','.','.','.'},
                new char[]{'.','.','.','.','.','3','.','.','1'},
                new char[]{'8','.','.','.','.','.','.','2','.'},
                new char[]{'.','.','2','.','7','.','.','.','.'},
                new char[]{'.','1','5','.','.','.','.','.','.'},
                new char[]{'.','.','.','.','.','2','.','.','.'},
                new char[]{'.','2','.','9','.','.','.','.','.'},
                new char[]{'.','.','4','.','.','.','.','.','.'}
            };
            Console.WriteLine(IsValidSudoku(board));
        }

        public static bool IsValidSudoku(char[][] board)
        {
            if (board == null || board.Length == 0) return false;
            return AreRowsValid(board) && AreColumnsValid(board) && AreSubSquaresValid(board);
        }

        private static bool AreSubSquaresValid(char[][] board)
        {
            bool bRet = true;
            HashSet<int> nums = new HashSet<int>();
            for (int i = 0; i < 9; i+=3)
            {
                for (int j = 0; j < 9; j+=3)
                {
                    for (int k = i; k < i+3; k++)
                    {
                        for (int l = j; l < j+3; l++)
                        {
                            if (board[k][l] != '.')
                            {
                                int num = (int)char.GetNumericValue(board[k][l]);
                                if (num > 0 && num < 10 && !nums.Contains(num))
                                    nums.Add(num);
                                else
                                {
                                    bRet = false;
                                    break;
                                }
                            }
                        }
                    }
                    nums.Clear();
                }
            }
            return bRet;
        }

        private static bool AreColumnsValid(char[][] board)
        {
            bool bRet = true;
            HashSet<int> numbers = new HashSet<int>();
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i][j] != '.')
                    {
                        int num = (int)char.GetNumericValue(board[i][j]);
                        if (num > 0 && num < 10 && !numbers.Contains(num))
                            numbers.Add(num);
                        else
                        {
                            bRet = false;
                            break;
                        }
                    }
                }
                numbers.Clear();
            }
            return bRet;
        }

        private static bool AreRowsValid(char[][] board)
        {
            bool bRet = true;
            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        int num = (int)char.GetNumericValue(board[i][j]);
                        if (num > 0 && num < 10 && !numbers.Contains(num))
                            numbers.Add(num);
                        else
                        {
                            bRet = false;
                            break;
                        }
                    }
                }
                numbers.Clear();
            }
            return bRet;
        }
    }
}
