using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace HashMapImplementation
{
    class Program
    {
        /*
         * Accepted Solution For Happy Numbers
         */
        static void Main(string[] args)
        {
            Console.WriteLine(IsHappy(2));
        }

        public static bool IsHappy(int n)
        {
            if (n < 0) return false;
            HashSet<int> nums = new HashSet<int>();
            nums.Add(n);
            int sum = n;
            while (true)
            {
                sum = GetSumOfDigits(sum);
                if(nums.Contains(sum))
                    return sum == 1;
                else
                    nums.Add(sum);
            }
        }

        public static int GetSumOfDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                int quotient = n / 10;
                int mod = n % 10;
                sum += mod * mod;
                n = quotient;
            }
            return sum;
        }
    }
   


}
