using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordLadder
{
    class MostCommonWord
    {
        public string MostCommonWord2(string paragraph, string[] banned)
        {
            if (string.IsNullOrEmpty(paragraph) || banned == null) return "";
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            paragraph = Regex.Replace(paragraph, @"[!?',;.]", " ").ToLower();
            foreach (string word in paragraph.Split(' ',StringSplitOptions.RemoveEmptyEntries))
            {
                string w = word.Trim();
                if (Array.IndexOf(banned, w) == -1)
                {
                    if (wordCount.ContainsKey(w))
                        wordCount[w] = wordCount[w] + 1;
                    else
                        wordCount.Add(w, 1);
                }
            }
            return wordCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key).First().Key;
        }
    }
}
