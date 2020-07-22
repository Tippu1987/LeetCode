using System;

namespace LC953
{
    class Program
    {
        /// <summary>
        /// In an alien language, surprisingly they also use english lowercase letters, 
        /// but possibly in a different order. The order of the alphabet is some permutation of lowercase letters.
        /// Given a sequence of words written in the alien language, and the order of the alphabet, 
        /// return true if and only if the given words are sorted lexicographicaly in this alien language.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] words = new string[] { "hello", "leetcode" };
            string order = "hlabcdefgijkmnopqrstuvwxyz";
            Console.WriteLine(IsAlienSorted(words, order));
        }
        public static bool IsAlienSorted(string[] words, string order)
        {
            if (words == null) return false;
            bool bRet = true;
            for (int i = 0, j = i + 1; j < words.Length; i++, j++)
            {
                if (bRet)
                    bRet &= Sorted(words[i], words[j], order);
                else
                    break;
            }
            return bRet;
        }
        public static bool Sorted(string source, string target, string order)
        {
            for (int i = 0; i < Math.Min(source.Length, target.Length); i++)
            {
                char a = i < source.Length ? source[i] : '\0';
                char b = i < target.Length ? target[i] : '\0';
                if (a != b)
                    return order.IndexOf(a) <= order.IndexOf(b);
            }
            return !(source.Length > target.Length);
        }
    }
}
