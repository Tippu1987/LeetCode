using System;
using System.Collections.Generic;
using System.Linq;

namespace ReorderDataInLogFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            Solution s = new Solution();
            foreach (var item in s.ReorderLogFiles(input))
                Console.WriteLine(item);
        }
    }
    public class Solution
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            if (logs == null || logs.Length == 0) return null;
            List<string> diglogs = new List<string>();
            List<string> inter = new List<string>();
            string[] output = new string[logs.Length];
            for (int i = 0; i < logs.Length; i++)
            {
                var split = logs[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (split[1].Any(char.IsDigit))
                    diglogs.Add(logs[i]);
                else
                    inter.Add(logs[i]);
            }
            var charlogsArray = inter.ToArray();
            Array.Sort(charlogsArray);
            for (int i = 0; i < charlogsArray.Length; i++)
            {
                output[i] = charlogsArray[i];
            }
            int k = charlogsArray.Length;
            foreach (string s in diglogs)
            {
                output[k++] = s;
            }
            return output;
        }
    }
}
