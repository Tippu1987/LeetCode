using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("III"));
            Console.WriteLine(RomanToInt("IV"));
            Console.WriteLine(RomanToInt("IX"));
            Console.WriteLine(RomanToInt("LVIII"));
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }

        public static int RomanToInt(string s)
        {
            Dictionary<string, int> romantoInt = new Dictionary<string, int>();
            romantoInt.Add("I", 1);
            romantoInt.Add("V", 5);
            romantoInt.Add("X", 10);
            romantoInt.Add("L", 50);
            romantoInt.Add("C", 100);
            romantoInt.Add("D", 500);
            romantoInt.Add("M", 1000);
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (romantoInt[s[i].ToString()] < romantoInt[s[i + 1].ToString()])
                {
                    result += romantoInt[s[i+1].ToString()] - romantoInt[s[i].ToString()];
                    continue;
                }
                else
                {
                    result += romantoInt[s[i].ToString()];
                }
            }
            return result;
        }
    }
}
