using System;
using System.Collections.Generic;
using System.Text;

namespace IsomorphicStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsomorphic("egg", "add"));
        }

        public static bool IsIsomorphic(string s, string t)
        {
            if (s == t) return true;
            if (s.Length != t.Length || string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return false;
            Dictionary<char, char> charMap = new Dictionary<char, char>();
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (!charMap.ContainsKey(s[i]) && !charMap.ContainsValue(t[i]))
                    charMap.Add(s[i], t[i]);
                res.Append(charMap.ContainsKey(s[i]) ? charMap[s[i]] : s[i]);
            }
            return res.ToString() == t;
        }
    }
}
