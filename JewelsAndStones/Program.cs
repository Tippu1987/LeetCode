using System;
using System.Collections.Generic;

namespace JewelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumJewelsInStones("z", "ZZ"));
        }

        public static int NumJewelsInStones(string J, string S)
        {
            if (string.IsNullOrEmpty(J) || string.IsNullOrEmpty(S)) return 0;

            int count = 0; HashSet<char> jewels = new HashSet<char>(J);
            for (int i = 0; i < S.Length; i++)
                if (jewels.Contains(S[i])) count++;
            return count;
        }
    }
}
