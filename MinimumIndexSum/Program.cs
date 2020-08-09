using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MinimumIndexSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqChar("dddccdbba"));
        }

        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            if (list1 == null || list2 == null || list1.Length == 0 || list2.Length == 0) return null;
            Dictionary<string, int> restCount = new Dictionary<string, int>();
            List<string> output = new List<string>();
            int sum = 2000;
            for(int i = 0; i < list1.Length; i++)
                restCount.Add(list1[i], i);
            for (int i = 0; i < list2.Length; i++)
            {
                if (restCount.ContainsKey(list2[i]))
                {
                    int k = i + restCount[list2[i]];
                    if (k < sum)
                    {
                        output.Clear();
                        output.Add(list2[i]);
                        sum = k;
                    }
                    else if (k == sum)
                    {
                        output.Add(list2[i]);
                        sum = k;
                    }
                }
            }
            return output.ToArray();
        }

        public static int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s)) return -1;
            Dictionary<char, int> charCnt = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!charCnt.ContainsKey(s[i]))
                    charCnt.Add(s[i], 1);
                else
                    charCnt[s[i]]++;
            }
            if (!charCnt.Any(x => x.Value == 1)) return -1;
            char val = charCnt.First(x => x.Value == 1).Key;
            return val == null ? -1 : s.IndexOf(val);
        }
    }
}
