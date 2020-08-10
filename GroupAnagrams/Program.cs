using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            GroupAnagrams(strs);
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs == null || strs.Length == 0) return null;
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            List<IList<string>> output = new List<IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                string sorted = strs[i].Sortstr();
                if (dict.ContainsKey(sorted))
                    dict[sorted].Add(strs[i]);
                else
                    dict.Add(sorted, new List<string> { strs[i] });
            }
            foreach (var item in dict)
                output.Add(item.Value);
            return output;
        }
    }
    public static class Extensions
    {
        public static string Sortstr(this String inp)
        {
            char[] chars = inp.ToArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
}
