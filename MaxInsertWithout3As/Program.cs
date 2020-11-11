using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml.Schema;

namespace MaxInsertWithout3As
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"L:\Interviews\input.txt";
            Console.WriteLine(MyAtoi("-91283472332"));
            //Console.WriteLine(solution(File.ReadAllText(path)));
        }
        private static int maxA(string s)
        {
            int cnt = 0, res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == 'a')
                    cnt++;
                else
                {
                    res += 2 - cnt;
                    cnt = 0;
                }
                if (cnt == 3)
                    return -1;
            }
            if (s[s.Length - 1] != 'a')
                res += 2;
            else
                res += 2 - cnt;
            return res;
        }

        private static string solution(string S)
        {
            int FourteenMB = 14 * 1024 * 1024;
            string nofiles = "NO FILES";
            if (string.IsNullOrEmpty(S)) return nofiles;
            var files = S.Split('\n');
            List<DateTime> times = new List<DateTime>();
            foreach (var line in files)
            {
                if (line.StartsWith("\"\"\"")) continue;
                if (line.StartsWith("admin") && line.Split(" ")[1].Contains("x") && Convert.ToInt32(line.Split(" ")[5]) < FourteenMB)
                {
                    CultureInfo culture = new CultureInfo("es-ES");
                    var datestr = line.Split(" ")[2] + "/" + line.Split(" ")[3] + "/" + line.Split(" ")[4];
                    times.Add(DateTime.Parse(datestr, culture));
                }
            }
            times.Sort();
            return times.Count == 0 ? nofiles : times[0].ToString("dd MMM yyyy");

        }

        public static int MyAtoi(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            s = s.Trim();
            if (char.IsLetter(s[0])) return 0;
            int i = 0;
            string num = "";
            while (i<s.Length && ( char.IsDigit(s[i]) || s[i] == '+' || s[i] == '-'))
            {
                num += s[i];
                i++;
            }
            i = num.Length - 1;
            int pow = 0;
            double number = 0;
            while (i >= 0)
            {
                if (char.IsDigit(s[i]))
                {
                    number += char.GetNumericValue(s[i]) * Math.Pow(10.00, (double)pow++);
                    if (number > int.MaxValue)
                        return s[0] == '-' ? int.MinValue : int.MaxValue;
                }
                if (s[i] == '-')
                    number *= -1;
                i--;
            }
            return (int)number;

        }

    }
}

