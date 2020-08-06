using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

namespace MatchingBraces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("(]"));
        }

        public static bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            Dictionary<char, char> charMap = new Dictionary<char, char>();
            charMap.Add('(', ')');
            charMap.Add('{', '}');
            charMap.Add('[', ']');
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char curChar = s[i];
                if (curChar == '(' || curChar == '{' || curChar == '[')
                    st.Push(curChar);
                else
                {
                    char stTop = st.Count > 0 ? st.Pop() : '#';
                    if (charMap.ContainsKey(stTop))
                        if (s[i] == charMap[stTop]) continue;
                        else
                            return false;
                    return false;
                }
            }
            return st.Count == 0;

        }
    }
}
