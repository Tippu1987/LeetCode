using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Console.WriteLine(s.LadderLength("hit", "cog", new List<string> { "hot", "dot", "dog", "lot", "log", "cog" }));
            //Console.WriteLine(s.LadderLength("a", "c", new List<string> { "a","b","c"}));
            //Console.WriteLine(s.LadderLength("hot", "dog", new List<string> { "hot", "dog" }));
            MostCommonWord mcw = new MostCommonWord();
            string paragraph = "a, a, a, a, b,b,b,c, c";
            string[] banned = new string[] { "a" };
            Console.WriteLine(mcw.MostCommonWord2(paragraph, banned));

        }
    }
    public class Solution
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (string.IsNullOrEmpty(beginWord) || string.IsNullOrEmpty(endWord) ||
               beginWord == endWord || !wordList.Contains(endWord)) return 0;
            Dictionary<string, HashSet<string>> adjacency = new Dictionary<string, HashSet<string>>();
            var WL = new HashSet<string>(wordList);
            foreach (string word in WL)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    string pattern = word[..i] + "[a-z]{1}" + word.Substring(i + 1);
                    Regex r = new Regex(pattern);
                    var matches = wordList.Where(x => r.Match(x).Success && x != word);
                    if (adjacency.ContainsKey(word))
                        adjacency[word].UnionWith(matches);
                    else
                        adjacency[word] = new HashSet<string>(matches);
                }
            }
            Queue<string> bfs = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();
            int length = 0;
            bfs.Enqueue(beginWord);
            HashSet<string> temp = new HashSet<string>();
            while (bfs.Count > 0)
            {
                while (bfs.Count > 0)
                {
                    var str = bfs.Dequeue();
                    visited.Add(str);
                    if (str != endWord)
                    {
                        if (adjacency.ContainsKey(str) && adjacency[str].Count > 0)
                            adjacency[str].Where(x => !visited.Contains(x)).ToList().ForEach(x => temp.Add(x));
                    }
                    else
                        return length;
                }
                if (temp.Count > 0)
                {
                   //temp.A (x => bfs.Enqueue(x));
                    temp.Clear();
                    length++;
                }
            }
            return length + 1;
        }
    }
}
