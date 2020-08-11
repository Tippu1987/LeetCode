using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LongestSubStrWithOutRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring(" "));
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            Dictionary<char,int> chars = new Dictionary<char, int>();
            int i = 0, maxLength=int.MinValue;
            while(i<s.Length)
            {
                if (!chars.ContainsKey(s[i]))
                {
                    chars.Add(s[i], i);
                    i++;
                }
                else
                {
                    maxLength = chars.Count > maxLength ? chars.Count : maxLength;
                    i = chars.Values.Min() + 1;
                    chars.Clear();
                }
            }
            return chars.Count > maxLength ? chars.Count : maxLength;
        }
    }
}
