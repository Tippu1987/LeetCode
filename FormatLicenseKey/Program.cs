using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormatLicenseKey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LicenseKeyFormatting("2-5g-3-J", 2)); ;
        }
    }

    public class Solution
    {
        public string LicenseKeyFormatting(string S, int K)
        {
            if (string.IsNullOrEmpty(S)) return S;
            S = S.Replace("-", "").ToUpper();

            int cnt = 0;
            string r = "";
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (cnt != K)
                {
                    r = S[i] + r;
                    cnt++;
                }
                else
                {
                    r = S[i] + "-" + r;
                    cnt = 1;
                }
            }
            return r;
        }
    }
}
