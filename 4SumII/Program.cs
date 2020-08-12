using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _4SumII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { -1, -1 };
            int[] B = new int[] { -1, 1 };
            int[] C = new int[] { -1, 1 };
            int[] D = new int[] { 1, -1 };
            Console.WriteLine(FourSumCount(A, B, C, D));
        }

        public static int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            if (A == null || B == null || C == null || D == null) return 0;
            if (A.Length == 0 || B.Length == 0 || C.Length == 0 || D.Length == 0) return 0;
            Dictionary<int, int> res = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    int sum = A[i] + B[j];
                    if (res.ContainsKey(sum))
                        res[sum] += 1;
                    else
                        res[sum] = 1;
                }
            }
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < D.Length; j++)
                {
                    int tempsum = -1 * (C[i] + D[j]);

                    if (res.ContainsKey(tempsum))
                        count += res[tempsum];
                }
            }
            return count;
        }
    }
}
