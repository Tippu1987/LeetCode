using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
            Console.WriteLine(IsPalindrome(-121));
            Console.WriteLine(IsPalindrome(10));
        }

        public static bool IsPalindrome(int x)
        {
            int orig = x;
            if (x < 0) return false;
            else
            {
                int rev = 0;
                while (x != 0)
                {
                    int pop = x % 10;
                    x /= 10;
                    rev = rev * 10 + pop;
                }
                return (orig == rev);
            }
        }
    }
}
