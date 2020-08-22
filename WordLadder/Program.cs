using System;
using System.Collections.Generic;

namespace WordLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
        }
    }

    public class Solution
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if(string.IsNullOrEmpty(beginWord)|| string.IsNullOrEmpty(endWord) || wordList==null|| wordList.Count==0 || !wordList.Contains(endWord)) return 0;
             ConstructGraph(wordList)
        }

        private void ConstructGraph(IList<string> wordList, string beginWord)
        {
            var head = new GraphNode(beginWord);

        }

        public class GraphNode
        {
            string val;
            List<GraphNode> neighbors;
            public GraphNode(string nodeval,List<GraphNode> neighbors=null )
            {
                val = nodeval;
                this.neighbors = neighbors != null ? neighbors : null;
            }
        }

    }
}
