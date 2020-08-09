using System;
using System.Collections.Generic;

namespace IsomorphicStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsomorphic("aa", "ab"));
        }

        public static bool IsIsomorphic(string s, string t)
        {
            if (s == t) return true;
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return false;
            Dictionary<char, char> charMap = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!charMap.ContainsKey(s[i]) && !charMap.ContainsValue(t[i]))
                    charMap.Add(s[i], t[i]);
            }
            string res = "";
            for (int i = 0; i < s.Length; i++)
                res += charMap.ContainsKey(s[i]) ? charMap[s[i]] : s[i];
            return res == t;
        }
    }
}
