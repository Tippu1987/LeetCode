using System;
using System.Collections.Generic;

namespace PartitionLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().PartitionLabels( "abadbcbacadefegdehijhklij"));
        }
    }

    public class Solution
    {
        public IList<int> PartitionLabels(string S)
        {
            if (string.IsNullOrEmpty(S)) return null;
            int[] charIndexes = new int[26];
            List<int> output = new List<int>();
            for (int k = 0; k < S.Length; k++)
                charIndexes[S[k] - 'a'] = k;
            int i = 0;
            while (i < S.Length)
            {
                int end = charIndexes[S[i] - 'a'];
                int j = i;
                while (j != end)
                {
                    end = Math.Max(end, charIndexes[S[j++] - 'a']);
                }
                output.Add(j - i + 1);
                i = j + 1;
            }
            return output;
        }
    }
}
