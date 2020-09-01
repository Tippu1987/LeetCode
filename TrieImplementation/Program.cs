using System;

namespace TrieImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie tr = new Trie();
            tr.Insert("apple");
            Console.WriteLine(tr.Search("apple"));
            Console.WriteLine(tr.Search("app"));
            Console.WriteLine(tr.StartsWith("app"));
            tr.Insert("app");
            Console.WriteLine(tr.Search("app"));
        }
    }

    public class Trie
    {
        TrieNode root;
        /** Initialize your data structure here. */
        public Trie()
        {
            root = new TrieNode('*');
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            if (string.IsNullOrEmpty(word) || Search(word)) return;
            int ind = 0;
            char curchar = word[ind];
            var curNode = root;
            while (curNode.nextPointers[curchar - 'a'] != null)
            {
                curNode = curNode.nextPointers[curchar - 'a'];
                curchar = ind + 1 < word.Length ? word[ind++] : '\0';
            }
            if (curNode.nextPointers[curchar - 'a'] == null)
            {
                while (ind < word.Length)
                {
                    curchar = word[ind++];
                    var newnode = new TrieNode(curchar);
                    
                    curNode.nextPointers[curchar - 'a'] =
                    curNode = curNode.nextPointers[curchar - 'a'];
                }
            }
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            if (string.IsNullOrEmpty(word)) return false;
            int ind = 0;
            var curNode = root;
            bool bret = false;
            while (curNode.end)
            {
                char curchar = word[ind];
                if (curNode.nextPointers[curchar - 'a'] != null)
                {
                    curNode = curNode.nextPointers[curchar - 'a'];
                    ind++;
                    bret = true;
                }
                else
                {
                    bret = false;
                    break;
                }
            }
            return bret;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            if (string.IsNullOrEmpty(prefix)) return false;
            return Search(prefix);
        }
    }

    public class TrieNode
    {
        public char val;
        public bool end;
        public TrieNode[] nextPointers;
        public TrieNode(char ch)
        {
            val = ch;
            nextPointers = new TrieNode[26];
            end = false;
        }
    }
}
