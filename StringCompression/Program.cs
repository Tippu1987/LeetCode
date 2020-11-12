using System;
using System.Text;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            Console.WriteLine(new Solution().Compress(chars));
        }
    }
    public class Solution
    {
        public int Compress(char[] chars)
        {
            if (chars == null || chars.Length == 0) return 0;
            int cnt = 1, oldindex = 0;
            StringBuilder s = new StringBuilder();
            for (int i = 0; i+1 < chars.Length; i++)
            {
                if (chars[i] == chars[i + 1])
                    cnt++;
                else
                {
                    s.Append(cnt > 1 ? chars[oldindex].ToString() + cnt : chars[oldindex].ToString());
                    oldindex++;
                    if (cnt > 1) chars[oldindex] = (i - oldindex+1).ToString()[0];
                    cnt = 1;
                }
            }
            s.Append(cnt > 1 ? chars[oldindex].ToString() + cnt : chars[oldindex].ToString());
            return s.Length;
        }
    }
}
